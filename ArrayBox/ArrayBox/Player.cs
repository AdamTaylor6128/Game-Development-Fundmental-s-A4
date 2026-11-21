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

        public Vector2 speed = new Vector2(-1,0);

        public Vector2 motion;

        //Draws the players 
        public void DrawBike()
        {
            Draw.SetFillColor(Color.White);
            Draw.Circle(position, 1);
        }


        //Movment controls for the player
        public void Movment()
        {
            Vector2 motion = speed * (Time.DeltaTime * 0.2f);

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

        //Returns if the player is outside of the bounds of the game
        public bool bounds()
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
                return true;

            }

            else
            {
                return false;
            }
        }

    }
}
