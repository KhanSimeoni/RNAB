using OpenTK;
using OpenTK.Graphics;

namespace WindowInit
{
    public class Game : GameWindow 
    {
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }
    }
}