using System;
using System.Numerics;

namespace MohawkGame2D;
public class Dodgeballs
{

    public float rate;
    public int amount;
    public int speed;
    public int size;
    public float startTime;


    private Vector2 position = new Vector2(400, 300);
    private int direction = Random.Integer(0, 2);
    private int side = Random.Integer(0, 2);
    private bool player_hit = false;
    private bool dodgeball_initialized = false;
    private bool detect_player = false;
    private bool added_to_count = false;


    //public void CreateDodgeball()
    //{
       // Vector2 position = new Vector2(400, 300);
        //int diretion = Random.Integer(0, 2);
       // int side = Random.Integer(0, 2);
       // bool player_hit = false;


    //}

    public void Update(Game game)
    {

        Player player = game.GetPlayer();

        if (added_to_count == false)
        {
            added_to_count = true;
            game.dodgeball_count++;
        }

        if (Vector2.Distance(position, player.position) < 25)
        {
            if (player_hit == false && detect_player == true)
            {
                player_hit = true;
                player.health -= 1;
            }
        }

        if (dodgeball_initialized == false)
        {

            if (direction == 0)
            {
                float random_y_pos = Random.Integer(90, 480);

                if (side == 0)
                {
                    position.X = -5;
                }
                else
                {
                    position.X = (Window.Size.X + 5);
                }

                position.Y = random_y_pos;
                dodgeball_initialized = true;
            }
            else
            {
                float random_x_pos = Random.Integer(70, 670);

                if (side == 0)
                {
                    position.Y = -15;
                }
                else
                {
                    position.Y = (Window.Size.Y + 15);
                }

                position.X = random_x_pos;
                dodgeball_initialized = true;

            }

        }
        else
        {

            detect_player = true;

            if (direction == 0)
            {
                if (side == 0)
                {
                    position.X += 350 * Time.DeltaTime;
                    Draw.SetFillColor(Color.Red);
                    Draw.Circle(position.X, position.Y, 25);
                }
                else
                {
                    position.X -= 350 * (Time.DeltaTime);
                    Draw.SetFillColor(Color.Red);
                    Draw.Circle(position.X, position.Y, 25);
                }
            }
            else
            {
                if (side == 0)
                {
                    position.Y += 350 * Time.DeltaTime;
                    Draw.SetFillColor(Color.Red);
                    Draw.Circle(position.X, position.Y, 25);
                }
                else
                {
                    position.Y -= 350 * Time.DeltaTime;
                    Draw.SetFillColor(Color.Red);
                    Draw.Circle(position.X, position.Y, 25);
                }
            }

        }




    }


}
