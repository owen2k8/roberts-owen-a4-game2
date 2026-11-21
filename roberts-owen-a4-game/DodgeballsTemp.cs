using System;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace MohawkGame2D
{

    public class MoveInfo
    {
        public Vector2 position = new Vector2(400, 300);
        public int direction = Random.Integer(0, 2);
        public int side = Random.Integer(0, 2);
        public float offset = 0;
    }
    
    public class DodgeballsTEMP
    {

        public MoveInfo CreateDodgeball()
        {

            MoveInfo info = new MoveInfo();

            if (info.direction == 0)
            {
                info.offset = Random.Integer(90, 480);

                if (info.side == 0)
                {
                    info.position.X = -5;
                }
                else
                {
                    info.position.X = (Window.Size.X + 5);
                }

                info.position.Y += info.offset;
            }
            else
            {
                info.offset = Random.Integer(70, 670);


                if (info.side == 0)
                {
                    info.position.X = -5;
                }
                else
                {
                    info.position.X = (Window.Size.X + 5);
                }

                info.position.Y += info.offset;

            }

            return info;

        }

        public void Update(MoveInfo info)
        {

            Console.WriteLine(info.position);

            if (info.direction == 0)
            {
                if (info.side == 0)
                {
                    info.position.X += 350 * Time.DeltaTime;
                    Draw.SetFillColor(Color.Red);
                    Draw.Circle(info.position.X, info.position.Y, 25);
                }
                else
                {
                    info.position.X -= 350 * (Time.DeltaTime);
                    Draw.SetFillColor(Color.Red);
                    Draw.Circle(info.position.X, info.position.Y, 25);
                }
            }
            else
            {
                if (info.side == 0)
                {
                    info.position.Y += 350 * Time.DeltaTime;
                    Draw.SetFillColor(Color.Red);
                    Draw.Circle(info.position.X, info.position.Y, 25);
                }
                else
                {
                    info.position.Y -= 350 * Time.DeltaTime;
                    Draw.SetFillColor(Color.Red);
                    Draw.Circle(info.position.X, info.position.Y, 25);
                }
            }
        }

    }

}
