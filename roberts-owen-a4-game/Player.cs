using System;
using System.Numerics;

namespace MohawkGame2D;

public class Player
{

    public Color player_color;
    public int speed;
    public float x;
    public float y;


    public void Update()
    {

        if (Input.IsKeyboardKeyDown(KeyboardKey.Up))
        {
            y -= speed * Time.DeltaTime;
        }
        if (Input.IsKeyboardKeyDown(KeyboardKey.Down))
        {
            y += speed * Time.DeltaTime;
        }
        if (Input.IsKeyboardKeyDown(KeyboardKey.Left))
        {
            x -= speed * Time.DeltaTime;
        }
        if (Input.IsKeyboardKeyDown(KeyboardKey.Right))
        {
            x += speed * Time.DeltaTime;
        }

        Draw.SetFillColor(player_color);
        Draw.Circle(x, y, 30);

    }

}
