using System;
using WindowInit;

namespace WindowMain
{
    class Program
    {
        static void Main() 
        {
            using (Game game = new Game(800, 600, "Testing")) 
            {
                game.Run(60.0);
            }
        }
    }
}