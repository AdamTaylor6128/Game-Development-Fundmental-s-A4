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
        public Vector2 squareSize = new Vector2(20, 20);

        bool first = false;
        bool second = false;
        Color fill = Color.Blue;

        public Vector2 point;
     

  
        public void SquareDraw()
        {
           
            float leftEdge = squarePosition.X;
            float rightEdge = squarePosition.X + squareSize.X;
            float topEdge = squarePosition.Y;
            float bottomEdge = squarePosition.Y + squareSize.X;
            // We need to check against all for edges
            bool isWithinX = point.X > leftEdge && point.X < rightEdge;
            bool isWithinY = point.Y > topEdge && point.Y < bottomEdge;
            // We can combine these two results into one
            bool isWithinRectangle = isWithinX && isWithinY;

            if (isWithinRectangle == true && second == false)
            {

                fill = Color.Red;
               

                first = true;
            }
            else if(isWithinRectangle == false && first == true)
            {
                second = true;
                fill = Color.Red;

            }
            else if(isWithinRectangle == true && second == true)
            {
                first = false;
                fill = Color.Green;

            }
          
            Draw.SetFillColor(fill);
            Draw.Square(squarePosition, squareSize.X);

        }
    }
}
