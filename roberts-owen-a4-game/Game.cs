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
        bool game_running = false;
        public int dodgeball_count = 0;
        float game_time;
        bool game_win = false;

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
                dodgeballs[i].startTime = (1 * i);

            }
        }


        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            Window.ClearBackground(255, 255, 255); 

            if (player.health <= 0)
            {
                game_running = false;
            }

            if (game_running == true)
            {

                game_time += Time.DeltaTime;
                //game_time = (int)game_time;
                Console.WriteLine(game_time);
                
                Draw.SetFillColor(Color.White);
                Draw.SetLineSize(10);
                Draw.SetLineColor(Color.Black);
                Draw.Rectangle(50, 50, 700, 500);

                Vector2 health_text_pos = new Vector2();
                health_text_pos.X = 20;
                health_text_pos.Y = 20;
                Text.Color = Color.Black;
                Text.Draw("Health: " + player.health, health_text_pos);

                Vector2 dodgeball_text_pos = new Vector2();
                dodgeball_text_pos.X = Window.Size.X - 350;
                dodgeball_text_pos.Y = 20;
                Text.Draw("Dodgeballs: " + dodgeball_count + "/" + dodgeballs.Length, dodgeball_text_pos);

                for (int i = 0; i < 100; i++)
                {
                    if (dodgeballs[i].startTime <= game_time)
                    {
                        dodgeballs[i].Update(this);
                    }
                }

                player.Update();

                if (dodgeball_count == 100)
                {
                    game_win = true;
                    game_running = false;
                }

            }

            else
            {
                
                if (game_win == true)
                {
                    Vector2 game_win_text = new Vector2();
                    game_win_text.X = 340;
                    game_win_text.Y = 285;
                    Text.Color = Color.Green;
                    Text.Draw("YOU WIN!", game_win_text);
                }
                
                if (player.health <= 0)
                {
                    Vector2 game_over_text = new Vector2();
                    game_over_text.X = 340;
                    game_over_text.Y = 285;
                    Text.Color = Color.Red;
                    Text.Draw("GAME OVER", game_over_text);
                }
                else
                {
                    if (game_win == false)
                    {
                        Vector2 begin_text = new Vector2();
                        begin_text.X = 220;
                        begin_text.Y = 285;
                        Text.Color = Color.Green;
                        Text.Draw("Press SPACE to start!", begin_text);
                    }
                }
               
            }

            if (Input.IsKeyboardKeyPressed(KeyboardKey.Space))
            {
                game_running = true;
            }

        }
    }

}
