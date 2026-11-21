using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    internal class Enemy
    {
        public Vector2 position = new Vector2(0, 200);

        public Vector2 playerP;

        public Vector2 speed = new Vector2(1, 1);

        public Vector2 motion;

        bool hit;


        public void DrawBike()
        {
            Draw.SetFillColor(Color.White);
            Draw.Circle(position, 10);
        }
        public void Movment()
        {
            Vector2 motion = speed * (Time.DeltaTime * 0.1f);

            Vector2 enemyToPlayer = playerP - position;

            Vector2 distance = Vector2.Normalize(enemyToPlayer);

            position += motion*distance;

           

        }
    }
}
