// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    /// 


    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        /// 

        public Player player = new Player();

        public void Setup()
        {
            Window.SetTitle("Dodgeball");
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;

            player.player_color = Color.Blue;
            player.speed = 150;
            player.size = 15;
            player.x = Window.Size.X / 2;
            player.y = Window.Size.Y / 2;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            Window.ClearBackground(255, 255, 255);

            Draw.SetFillColor(Color.White);
            Draw.SetLineSize(10);
            Draw.SetLineColor(Color.Black);
            Draw.Rectangle(50, 50, 700, 500);

            player.Update();
        }
    }

}
