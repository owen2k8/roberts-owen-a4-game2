using System;
using System.Numerics;

namespace MohawkGame2D;

public class Player
{

    //defines variables
    public Color player_color;
    public int health = 3;
    public int speed;
    public int size;
    public Vector2 position = new Vector2();

    //defines arrays
    public float[] borders = [0, 0, 0, 0];
    public float[] square_borders = [60, 740, 60, 540];

    public void Update()
    {

        //checks if a player is holding a directional key and updates their position
        if (Input.IsKeyboardKeyDown(KeyboardKey.Up) && borders[3] != square_borders[2])
        {
            position.Y -= speed * Time.DeltaTime;
        }
        if (Input.IsKeyboardKeyDown(KeyboardKey.Down) && borders[2] != square_borders[3])
        {
            position.Y += speed * Time.DeltaTime;
        }
        if (Input.IsKeyboardKeyDown(KeyboardKey.Left) && borders[1] != square_borders[0])
        {
            position.X -= speed * Time.DeltaTime;
        }
        if (Input.IsKeyboardKeyDown(KeyboardKey.Right) && borders[0] != square_borders[1])
        {
            position.X += speed * Time.DeltaTime;
        }

        //draws the player character
        Draw.SetFillColor(player_color);
        Draw.SetLineSize(0);
        Draw.Circle(position.X, position.Y, size);

        //updates the player's collision box
        borders[0] = position.X + size;
        borders[1] = position.X - size;
        borders[2] = position.Y + size;
        borders[3] = position.Y - size;

    }

}
