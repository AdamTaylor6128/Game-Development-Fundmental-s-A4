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
        
        float speed = 1*Time.DeltaTime;

        public Vector2 motion = new Vector2(-1 * Time.DeltaTime, 0);

        public void DrawBike()
        {

            Draw.Circle(position, 5);
        }


        public void Movment()
        {
            position += motion;
            
            if(Input.IsKeyboardKeyDown(KeyboardKey.W))
            {
                motion = new Vector2(0, -speed);              
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.A))
            {
                motion = new Vector2(-speed, 0);
               
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.S))
            {
                motion = new Vector2(0, +speed);
                
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.D))
            {
                motion = new Vector2(+speed, 0);
                
            }

        }


    }
}
