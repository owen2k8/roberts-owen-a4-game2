using System;
using System.Numerics;

namespace MohawkGame2D;
public class Dodgeballs
{

    public float rate;
    public int amount;
    public int speed;
    public int size;


    private Vector2 position = new Vector2(400, 300);
    private int direction = Random.Integer(0, 2);
    private int side = Random.Integer(0, 2);
    private bool player_hit = false;
    private bool dodgeball_initialized = false;


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

        bool is_player_colliding = Vector2.Distance(position, player.position) <= 25;

        if (is_player_colliding == true && player_hit == false)
        {
            player_hit = true;
            player.health -= 1;
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
                    position.Y += 360 * Time.DeltaTime;
                    Draw.SetFillColor(Color.Red);
                    Draw.Circle(position.X, position.Y, 25);
                }
                else
                {
                    position.Y -= 360 * Time.DeltaTime;
                    Draw.SetFillColor(Color.Red);
                    Draw.Circle(position.X, position.Y, 25);
                }
            }

        }




    }


}
