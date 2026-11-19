using System;
using System.Numerics;

namespace MohawkGame2D;

public class Player
{

    public Color player_color;
    public int health = 3;
    public int speed;
    public int size;
    public Vector2 position = new Vector2();

    public float[] borders = [0, 0, 0, 0];
    public float[] square_borders = [60, 740, 60, 540];

    public void Update()
    {

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

        Draw.SetFillColor(player_color);
        Draw.SetLineSize(0);
        Draw.Circle(position.X, position.Y, size);

        borders[0] = position.X + size;
        borders[1] = position.X - size;
        borders[2] = position.Y + size;
        borders[3] = position.Y - size;

    }

}
