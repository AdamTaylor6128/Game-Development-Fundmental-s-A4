using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Numerics;
using System.Text;


namespace MohawkGame2D
{
    internal class Player
    {

        public Vector2 position = new Vector2(200, 200);

        Vector2 speed = new Vector2(-1,0);

        public Vector2 motion;

        public void DrawBike()
        {

            Draw.Circle(position, 4);
        }


        public void Movment()
        {
            Vector2 motion = speed * (Time.DeltaTime * 0.4f);

            position += motion;
            
            if(Input.IsKeyboardKeyDown(KeyboardKey.W))
            {
                speed = new Vector2(0, -1);              
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.A))
            {
                speed = new Vector2(-1,0);

            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.S))
            {
                speed = new Vector2(0, +1);

            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.D))
            {
                speed = new Vector2(+1,0);

            }

        }

        public void bounds()
        {
            float playerLeftEdge = position.X;
            float playerRightEdge = position.X;
            float playerTopEdge = position.Y;
            float playerBottomEdge = position.Y;
               

            bool isLeftOfWindow = playerLeftEdge <= 0;             // left check
            bool isRightOfWindow = playerRightEdge >= Window.Width;  // right check
            bool isAboveWindow = playerTopEdge <= 0;             // top check
            bool isBelowWindow = playerBottomEdge >= Window.Height; // bottom check
            if (isLeftOfWindow == true || isRightOfWindow == true || isAboveWindow == true || isBelowWindow == true)
            {
                position = new Vector2(200, 200);

            }


        }

    }
}
