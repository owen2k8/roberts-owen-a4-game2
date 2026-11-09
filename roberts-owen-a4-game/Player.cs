using System;
using System.Numerics;

namespace MohawkGame2D;

public class Player
{

    public Color player_color;
    public int speed;
    public int size;
    public float x;
    public float y;

    public float[] borders = [0, 0, 0, 0];
    int square_x_least = 60;
    int square_x_most = 740;
    int square_y_least = 60;
    int square_y_most = 540;

    public void Update()
    {

        if (Input.IsKeyboardKeyDown(KeyboardKey.Up) && borders[3] != square_y_least)
        {
            y -= speed * Time.DeltaTime;
        }
        if (Input.IsKeyboardKeyDown(KeyboardKey.Down) && borders[2] != square_y_most)
        {
            y += speed * Time.DeltaTime;
        }
        if (Input.IsKeyboardKeyDown(KeyboardKey.Left) && borders[1] != square_x_least)
        {
            x -= speed * Time.DeltaTime;
        }
        if (Input.IsKeyboardKeyDown(KeyboardKey.Right) && borders[0] != square_x_most)
        {
            x += speed * Time.DeltaTime;
        }

        Console.WriteLine(borders[2]);

        Draw.SetFillColor(player_color);
        Draw.SetLineSize(0);
        Draw.Circle(x, y, size);

        borders[0] = x + size;
        borders[1] = x - size;
        borders[2] = y + size;
        borders[3] = y - size;

    }

}
