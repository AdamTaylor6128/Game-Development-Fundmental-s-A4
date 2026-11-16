using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Diagnostics.Tracing;


namespace MohawkGame2D
{
    internal class Player
    {

        public Vector2 position = new Vector2(200, 200);
        
        float speed = 10*Time.DeltaTime;

        public Vector2 motion;

        public void DrawBike()
        {

            Draw.Circle(position, 50);
        }


        public void Movment()
        {
            if(Input.IsKeyboardKeyDown(KeyboardKey.W))
            {
                motion = new Vector2(0, -speed);

                position += motion;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.A))
            {
                motion = new Vector2(-speed, 0);
                position += motion;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.S))
            {
                motion = new Vector2(0, +speed);
                position += motion;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.D))
            {
                motion = new Vector2(+speed, 0);
                position += motion;
            }

        }


    }
}
