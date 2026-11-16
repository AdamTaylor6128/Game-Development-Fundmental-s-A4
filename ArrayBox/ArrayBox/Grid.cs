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

        Vector2 point;
     

  
        public void SquareDraw()
        {
            point = Input.GetMousePosition();
            float leftEdge = squarePosition.X;
            float rightEdge = squarePosition.X + squareSize.X;
            float topEdge = squarePosition.Y;
            float bottomEdge = squarePosition.Y + squareSize.X;
            // We need to check against all for edges
            bool isWithinX = point.X > leftEdge && point.X < rightEdge;
            bool isWithinY = point.Y > topEdge && point.Y < bottomEdge;
            // We can combine these two results into one
            bool isWithinRectangle = isWithinX && isWithinY;

            if (isWithinRectangle == true)
            {

                Draw.SetFillColor(Color.Red);
                
                Draw.Square(squarePosition, squareSize.X);
            }
            else
            {
                Draw.SetFillColor(Color.Blue);
             
                Draw.Square(squarePosition, squareSize.X);
            }


          
        }
    }
}
