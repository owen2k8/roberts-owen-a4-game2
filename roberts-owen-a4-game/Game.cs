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

        //Defines the player, dodgeballs and variables
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


            //sets player variables
            player.player_color = Color.Blue;
            player.speed = 150;
            player.size = 15;
            player.position.X = Window.Size.X / 2;
            player.position.Y = Window.Size.Y / 2;


            //creates the dodgeballs and what time they should appear
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

            //checks if player health is at 0
            if (player.health <= 0)
            {
                //stops the game
                game_running = false;
            }

            if (game_running == true)
            {

                //updates game time for dodgeball system
                game_time += Time.DeltaTime;
                Console.WriteLine(game_time);
                
                Draw.SetFillColor(Color.White);
                Draw.SetLineSize(10);
                Draw.SetLineColor(Color.Black);
                Draw.Rectangle(50, 50, 700, 500);

                //draws text
                Vector2 health_text_pos = new Vector2();
                health_text_pos.X = 20;
                health_text_pos.Y = 20;
                Text.Color = Color.Black;
                Text.Draw("Health: " + player.health, health_text_pos);

                Vector2 dodgeball_text_pos = new Vector2();
                dodgeball_text_pos.X = Window.Size.X - 350;
                dodgeball_text_pos.Y = 20;
                Text.Draw("Dodgeballs: " + dodgeball_count + "/" + dodgeballs.Length, dodgeball_text_pos);

                //updates dodgeballs
                for (int i = 0; i < 100; i++)
                {
                    if (dodgeballs[i].startTime <= game_time)
                    {
                        dodgeballs[i].Update(this);
                    }
                }

                //updates player
                player.Update();

                //checks if all the dodgeballs have passed
                if (dodgeball_count == 100)
                {
                    game_win = true;
                    game_running = false;
                }

            }

            else
            {
                
                //displays win screen
                if (game_win == true)
                {
                    Vector2 game_win_text = new Vector2();
                    game_win_text.X = 340;
                    game_win_text.Y = 285;
                    Text.Color = Color.Green;
                    Text.Draw("YOU WIN!", game_win_text);
                }
                
                //displays game over screen
                if (player.health <= 0)
                {
                    Vector2 game_over_text = new Vector2();
                    game_over_text.X = 340;
                    game_over_text.Y = 285;
                    Text.Color = Color.Red;
                    Text.Draw("GAME OVER", game_over_text);
                }
                //displays start screen
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

            //detects if the player pressed space
            if (Input.IsKeyboardKeyPressed(KeyboardKey.Space))
            {
                game_running = true;
            }

        }
    }

}
