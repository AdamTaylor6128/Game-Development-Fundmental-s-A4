using MohawkGame2D;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    internal class Grid
    {
        public Vector2 squarePosition = new Vector2(0,0);
        public Vector2 squareSize = new Vector2(10, 10);

        bool first = false;
        bool collision = false;
        int opacity = 100;
        //Returns true if the player is able to be hit
        public bool hit = false;
        Color trail = Color.Blue;

        public Vector2 point;
     

        //Detects the collision of the character
        public void SquareDraw()
        {
           
            float leftEdge = squarePosition.X;
            float rightEdge = squarePosition.X + squareSize.X;
            float topEdge = squarePosition.Y;
            float bottomEdge = squarePosition.Y + squareSize.X;
            // Check each side and see if player is out-of-bounds


            


            // We need to check against all for edges
            bool isWithinX = point.X > leftEdge && point.X < rightEdge;
            bool isWithinY = point.Y > topEdge && point.Y < bottomEdge;
            // We can combine these two results into one
            bool isWithinRectangle = isWithinX && isWithinY;


            Draw.SetFillColor(5, opacity);
            if (isWithinRectangle == true && collision == false)
            {

                trail = Color.Red;
                Draw.SetFillColor(trail);

                first = true;
            }
            else if(isWithinRectangle == false && first == true)
            {
                collision = true;
                trail = Color.Red;
                Draw.SetFillColor(trail);
            }
            else if(isWithinRectangle == true && collision == true)
            {
                first = false;
                hit = true;
                
                Window.ClearBackground(0);
            }
            
           
            Draw.SetLineSize(1);
            Draw.Square(squarePosition, squareSize.X);


        }

      


    }
}
