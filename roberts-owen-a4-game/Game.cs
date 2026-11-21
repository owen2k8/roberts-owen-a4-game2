// Include the namespaces (code libraries) you need below.
using System;
using System.Globalization;
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
        Dodgeballs[] dodgeballs = new Dodgeballs[100];

        int previous_value = 0;

        public Player GetPlayer()
        {
            return player;
        }

        public void Setup()
        {
            Window.SetTitle("Dodgeball");
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;

            player.player_color = Color.Blue;
            player.speed = 150;
            player.size = 15;
            player.position.X = Window.Size.X / 2;
            player.position.Y = Window.Size.Y / 2;

            for (int i = 0; i < dodgeballs.Length; i++)
            {
                dodgeballs[i] = new Dodgeballs();
            }
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

            //float seconds = Time.SecondsElapsed;
           // int rotation = 1;
           
           // Console.WriteLine((int)seconds);
           // Console.WriteLine(previous_value);

            //if ((int)seconds != previous_value)
            //{

                //for (int i = 0; i < rotation; i++)
               // {
                // dodgeballs[i].Update(this);
               // }
            //}

            //rotation += 1;
            //previous_value = (int)seconds;

            for (int i = 0; i < dodgeballs.Length; i++)
            {
                dodgeballs[i].Update(this);
            }

            player.Update();

        }
    }

}
