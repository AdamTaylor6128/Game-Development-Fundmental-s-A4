using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    internal class Screens
    {
        Font byteBounc = Text.LoadFont("../../../../Assets/ByteBounce.ttf");
        
        //Game start screen
        public void Start()
        {

        }
        
        //Background behind the play area
        public void Background()
        {
            
        }
        //Game Over screen 
        public void GameOver()
        {
            Text.Color = Color.Red;
            Text.Font = byteBounc;
            Window.ClearBackground(244);
            Vector2 position = Vector2.One * 5;
            Text.Draw("Game Over", position);
        }

        public void YouWin()
        {
            Text.Color = Color.Red;
            Text.Font = byteBounc;
            Window.ClearBackground(244);
            Vector2 position = Vector2.One * 5;
            Text.Draw("You Win", position);
        }
    }
}
