using Gui.Sharp.Gfx.Interfaces;
using System;

namespace Gui.Sharp.Gfx.Factories
{
    public class GfxFactory
    {      
        public static T Create<T>()
        {
            var name = typeof(T).Name;

            switch (name)
            {
                case "IGfxCanvas":
                    return (T)(IGfxCanvas)new TGLCanvas();
                case "IScreen":
                    return (T)(IScreen)new TGLScreenIndependent();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
