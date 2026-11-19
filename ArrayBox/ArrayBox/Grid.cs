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

        public bool hit = false;
        Color fill = Color.Blue;

        public Vector2 point;
     

  
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

            Draw.SetFillColor(fill);
            Draw.SetLineSize(1);
            Draw.Square(squarePosition, squareSize.X);

            if (isWithinRectangle == true && collision == false)
            {

                fill = Color.Red;
               

                first = true;
            }
            else if(isWithinRectangle == false && first == true)
            {
                collision = true;
                fill = Color.Red;

            }
            else if(isWithinRectangle == true && collision == true)
            {
                first = false;
                hit = true;
                fill = Color.Green;
                Window.ClearBackground(0);
            }
          
            

        }

      


    }
}
