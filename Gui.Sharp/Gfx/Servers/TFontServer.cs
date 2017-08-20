using Gui.Sharp.Dom;
using Gui.Sharp.Gfx.Interfaces;
using OpenTK;
using QuickFont;
using QuickFont.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;

namespace Gui.Sharp.Gfx.Servers
{
    public class TFontServer : IFontServer
    {
        #region Constants

        private float DefaultFontSize = 18.0f;
        private const string TimesNewRoman = "Times New Roman";
        private const string Arial = "Arial";
        private const string Consolas = "Consolas";

        #endregion

        #region Private Members

        private QFontDrawing drawing;
        private Matrix4 projectionMatrix;
        private IEnumerable<string> defaultFontNames;

        #endregion

        #region Public Methods

        public float ScreenWidth { get; private set; }
        public float ScreenHeight { get; private set; }
        public IDictionary<string, QFont> Fonts { get; private set; }
        public IDictionary<string, QFont> DefaultFonts { get; private set; }
        public QFontBuilderConfiguration BuilderConfiguration { get; private set; } 

        #endregion

        #region Singleton

        private static readonly Lazy<TFontServer> lazy = new Lazy<TFontServer>(() => new TFontServer());
        public static TFontServer Instance => lazy.Value;

        #endregion

        private TFontServer()
        {
            drawing = new QFontDrawing();
            defaultFontNames = new List<string>() { TimesNewRoman, Arial, Consolas};

            Fonts = new Dictionary<string, QFont>();
            DefaultFonts = new Dictionary<string, QFont>();
            BuilderConfiguration = new QFontBuilderConfiguration(true)
            {
                ShadowConfig = { BlurRadius = 1, BlurPasses = 1, Type = ShadowType.Blurred },
                TextGenerationRenderHint = TextGenerationRenderHint.ClearTypeGridFit,
                Characters = CharacterSet.General | CharacterSet.Japanese | CharacterSet.Thai | CharacterSet.Cyrillic
            };
        }

        public void Initialize(int screenWidth, int screenHeight)
        {
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;

            projectionMatrix = Matrix4.CreateOrthographicOffCenter(0, screenWidth, 0, screenHeight, -1.0f, 1.0f);

            var ifc = new InstalledFontCollection();
            var defaultFontFamilies = ifc.Families.Where(x => defaultFontNames.Contains(x.Name));

            foreach (var fontFamily in defaultFontFamilies)
            {
                DefaultFonts.Add
                (
                    fontFamily.Name, 
                    new QFont(fontFamily.Name, DefaultFontSize, BuilderConfiguration, 
                    System.Drawing.FontStyle.Regular)
                );
            }
        }

        public void RenderText(string text, TFont font, Point position)
        {
            drawing.ProjectionMatrix = projectionMatrix;
            drawing.DrawingPrimitives.Clear();

            var qfont = Fonts.ContainsKey(font.Name) ?
                Fonts[font.Name] :
                DefaultFonts[TimesNewRoman];

            drawing.Print
            (
                qfont,
                text,
                new Vector3(position.X, ScreenHeight - position.Y, 0),
                QFontAlignment.Left,
                font.RenderOptions
            );

            drawing.RefreshBuffers();
            drawing.Draw();
        }
    }
}
