using Gui.Sharp.Dom.Factories;
using Gui.Sharp.Dom.Interfaces;
using Gui.Sharp.Gfx.Factories;
using Gui.Sharp.Gfx.Interfaces;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using System;

namespace Gui.Sharp.Gfx.OpenGL
{
    public class TGLGame : IGfxGame
    {
        #region Properties

        private GameWindow Window { get; set; }
        public IScreen Screen { get; set; }

        #endregion

        #region Methods

        public void Create(int width, int height, GameWindowFlags windowFlags, string htmlDocument)
        {
            var document = DomFactory.Create<IDocument>();
            document.Parse(htmlDocument);

            Screen = GfxFactory.Create<IScreen>();
            Screen.Create(width, height, Color.White, document);

            Window = new GameWindow(width, height, GraphicsMode.Default, "Gui Sharp Tests", windowFlags)
            {
                VSync = VSyncMode.On
            };

            Window.Load += OnLoad;
            Window.Resize += OnResize;
            Window.UpdateFrame += OnUpdateFrame;
            Window.RenderFrame += OnRenderFrame;
            Window.Disposed += OnDispose;
        }

        /// <summary>
        ///  From OpenTK documentation of GameWindow.Run()
        ///  Enters the game loop of the GameWindow updating and rendering at the specified
        ///  frequency.
        /// </summary>
        /// <param name="updatesPerSecond">The frequency of UpdateFrame events.</param>
        /// <param name="framesPerSecond">The frequency of RenderFrame events.</param>
        /// <remarks>
        ///  When overriding the default game loop you should call ProcessEvents() to ensure
        ///  hat your GameWindow responds to operating system events.
        ///  Once ProcessEvents() returns, it is time to call update and render the next frame.
        /// </remarks>
        public void Run(double updatesPerSecond, double framesPerSecond)
        {
            Window.Run(updatesPerSecond, framesPerSecond);
        }

        /// <summary>
        ///  From OpenTK documentation of GameWindow.Run()
        ///  Enters the game loop of the GameWindow using the specified update rate.maximum
        /// possible render frequency.
        /// </summary>
        /// <param name="updateRate"></param>
        public void Run(double updateRate)
        {
            Window.Run(updateRate);
        }

        /// <summary>
        /// From OpenTK documentation of GameWindow.Run()
        /// Enters the game loop of the GameWindow using the maximum update rate.
        /// </summary>
        public void Run()
        {
            Window.Run();
        }

        #endregion


        #region Event Handlers

        private void OnLoad(object sender, EventArgs e)
        {
        }

        private void OnRenderFrame(object sender, FrameEventArgs e)
        {
            Screen.Paint();

            Window.SwapBuffers();
        }

        private void OnUpdateFrame(object sender, FrameEventArgs e)
        {
            if (Window.Keyboard[Key.Escape])
                Window.Exit();
        }

        private void OnResize(object sender, EventArgs e)
        {
        }

        private void OnDispose(object sender, EventArgs e)
        {
        }

        #endregion
    }
}
