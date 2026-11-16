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
    private int direction = Random.Integer(0, 1);
    private int side = Random.Integer(0, 1);
    private bool player_hit = false;
    private bool dodgeball_initialized = false;

    public void Update(Game game)
    {

        Player player = game.GetPlayer();

        Console.WriteLine(dodgeball_initialized);
        
        if (dodgeball_initialized == false)
        {

            //Console.WriteLine("HSADBHSBDAHDSBASDASD");

            if (direction == 0)
            {
                float random_y_pos = Random.Integer(60, 540);
                position.X = -5;
                position.Y = random_y_pos;
                dodgeball_initialized = true;
            }

        }
        else
        {
            position.X += 350 * Time.DeltaTime;
            Draw.Circle(position.X, position.Y, 25);
        }




    }


}
