using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    internal class Screens
    {
        Font byteBounc = Text.LoadFont("\\..\\..\\taylo\\source\\repos\\Game-Development-Fundmental-s-A5\\ArrayBox\\Assets\\ByteBounce.ttf");
        

        public void Start()
        {

        }
        public void Background()
        {
            
        }
        public void GameOver()
        {

            Text.Font = byteBounc;
            Window.ClearBackground(244);
            Vector2 position = Vector2.One * 5;
            Text.Draw("Game Over", position);
        }
    }
}
