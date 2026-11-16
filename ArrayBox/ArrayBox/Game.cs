// Include the namespaces (code libraries) you need below.
using System;
using System.Drawing;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    

    // We can combine these two results into one
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        // A rectangle is a position and size. A point is just a position.
        // These values can be anything you wish.

        Grid[,] Draws = new Grid[40,40];
        

        public void Setup()
        {
            Window.SetSize(400, 400);
            
            for (int i = 0; i < Draws.GetLength(0); i++)
            {
                for (int j = 0; j < Draws.GetLength(1); j++)
                {
                    
                    Draws[i,j] = new Grid();
                    Draws[i, j].squarePosition.X += i * 10;
                    Draws[i, j].squarePosition.Y += j * 10;
                    //Draws[i, j].Setup();
                }
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            
            
            for (int i = 0; i < Draws.GetLength(0); i++)
            {
                for (int j = 0; j < Draws.GetLength(1); j++)
                {
                    
                    Draws[i, j].SquareDraw();
                    
                    

                }
            }

        }
        

      
    
    
    
    }

}
