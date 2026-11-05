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

        Player player = new Player();

        public void Setup()
        {
            Window.SetTitle("Dodgeball");
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;

            player.player_color = Color.Red;
            player.speed = 150;
            player.x = Window.Size.X / 2;
            player.y = Window.Size.Y / 2;

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            Window.ClearBackground(255, 255, 255);
            
            player.Update();
        }
    }

}
