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

        Grid[,] gridP = new Grid[40,40];

        Grid[,] gridE = new Grid[40, 40];
        Player tron = new Player();
        Screens screen = new Screens();

        Enemy enemy = new Enemy();

        bool GameOver = false;

        public void Setup()
        {
            Window.SetSize(400, 400);
            
            for (int i = 0; i < gridP.GetLength(0); i++)
            {
                for (int j = 0; j < gridP.GetLength(1); j++)
                {
                    
                    gridP[i,j] = new Grid();
                    gridP[i, j].squarePosition.X += i * 10;
                    gridP[i, j].squarePosition.Y += j * 10;
                    gridE[i, j] = new Grid();
                    gridE[i, j].squarePosition.X += i * 10;
                    gridE[i, j].squarePosition.Y += j * 10;
                 
                }
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            for (int i = 0; i < gridP.GetLength(0); i++)
            {
                for (int j = 0; j < gridP.GetLength(1); j++)
                {

                    tron.bounds();

                    

                    if (tron.bounds() == true || gridP[i, j].hit == true)
                    {

                        Window.ClearBackground(0);
                        screen.GameOver();
                        tron.speed = new Vector2(0, 0);
                    }
                    if (gridE[i, j].hit == true)
                    {

                        Window.ClearBackground(0);
                        screen.YouWin();
                        tron.speed = new Vector2(0, 0);
                    }
                    else if(GameOver==false)
                    {
                        
                        tron.Movment();
                        enemy.Movment();
                        
                        gridP[i, j].point = tron.position;
                        gridE[i, j].point = enemy.position;
                        enemy.playerP = tron.position;

                        enemy.DrawBike();
                        tron.DrawBike();
                        gridP[i, j].SquareDraw();
                        gridE[i, j].SquareDraw();

                        //gridP[i, j].hit = gridE[i, j].hit;
                        //gridE[i, j].hit = gridP[i, j].hit;
                            
                    
                    }
                   


                }
            }

          
        }


    }

}
