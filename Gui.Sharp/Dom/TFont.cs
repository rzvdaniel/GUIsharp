using OpenTK;
using QuickFont;

namespace Gui.Sharp.Dom
{
    public class TFont
    {
        /// <summary>
        /// Font family name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The font colour
        /// </summary>
        private Color colour;
        public Color Colour
        {
            get { return colour; }
            set
            {
                if (value != null && colour != value)
                {
                    colour = value;
                    RenderOptions.Colour = System.Drawing.Color.FromArgb
                    (
                        new Color(value.R, value.G, value.B, value.A).ToArgb()
                    );
                }
            }
        }

        /// <summary>
        /// Spacing between characters in units of average glyph width
        /// </summary>
        private float characterSpacing;
        public float CharacterSpacing
        {
            get { return characterSpacing; }
            set
            {
                if (characterSpacing != value)
                {
                    characterSpacing = value;
                    RenderOptions.CharacterSpacing = value;
                }
            }
        }

        /// <summary>
        /// Spacing between words in units of average glyph width
        /// </summary>
        private float wordSpacing;
        public float WordSpacing
        {
            get { return wordSpacing; }
            set
            {
                if (wordSpacing != value)
                {
                    wordSpacing = value;
                    RenderOptions.WordSpacing = value;
                }
            }
        }

        /// <summary>
        /// Line spacing in units of max glyph width
        /// </summary>
        private float lineSpacing;
        public float LineSpacing
        {
            get { return lineSpacing; }
            set
            {
                if (lineSpacing != value)
                {
                    lineSpacing = value;
                    RenderOptions.LineSpacing = value;
                }
            }
        }

        /// <summary>
        /// Whether to draw a drop-shadow. Note: this requires
        /// the QFont to have been loaded with a drop shadow to
        /// take effect.
        /// </summary>
        private bool dropShadowActive;
        public bool DropShadowActive
        {
            get { return dropShadowActive; }
            set
            {
                if (dropShadowActive != value)
                {
                    dropShadowActive = value;
                    RenderOptions.DropShadowActive = value;
                }
            }
        }

        /// <summary>
        /// Offset of the shadow from the font glyphs in units of average glyph width
        /// </summary>
        private Vector2 dropShadowOffset;
        public Vector2 DropShadowOffset
        {
            get { return dropShadowOffset; }
            set
            {
                if (value != null && dropShadowOffset != value)
                {
                    dropShadowOffset = value;
                    RenderOptions.DropShadowOffset = value;
                }
            }
        }

        /// <summary>
        /// Opacity of drop shadows
        /// </summary>
        private Color dropShadowColour;
        public Color DropShadowColour
        {
            get { return dropShadowColour; }
            set
            {
                if (value != null && dropShadowColour != value)
                {
                    dropShadowColour = value;
                    RenderOptions.DropShadowColour = System.Drawing.Color.FromArgb
                    (
                        new Color(value.R, value.G, value.B, value.A).ToArgb()
                    );
                }
            }
        }

        /// <summary>
        /// Set the opacity of the drop shadow
        /// </summary>
        public float DropShadowOpacity
        {
            set
            {
                DropShadowColour = new Color
                (
                    DropShadowColour.R, 
                    DropShadowColour.G,
                    DropShadowColour.B, 
                    value
                );
            }
        }

        public QFontRenderOptions RenderOptions { get; private set; }

        public TFont()
        {
            RenderOptions = new QFontRenderOptions();

            Colour = Color.Black;
            CharacterSpacing = 0.05f;
            WordSpacing = 0.9f;
            LineSpacing = 1.0f;
            DropShadowOffset = new Vector2(0.16f, 0.16f);
            DropShadowColour = new Color(0.0f, 0.0f, 0.0f, 0.5f);
        }
    }
}
