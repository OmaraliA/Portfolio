using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Drawing;

namespace NewGame
{
    class Characters
    {
        public int type = 0;
        public Vector2 CharacterCoordinates = new Vector2(0, 0);
        public static Vector2 MilkCoordinate = new Vector2(700, 350);
        private float dx, dy, dx1, dy1, dx2, dy2;
        public Characters()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int rand01 = rand.Next() % 2;
            CharacterCoordinates.X = rand.Next(700) * rand01;
            CharacterCoordinates.Y = rand.Next(350) * (1 - rand01);
            dx = (MilkCoordinate.X - CharacterCoordinates.X) / 1000;
            dy = (MilkCoordinate.Y - CharacterCoordinates.Y) / 1000;
        }
        public Characters(int t)
        {
            type = t;
            if (type == 1)
            {
                Random rand_bird = new Random();
                int b_rand01 = rand_bird.Next() % 2;
                CharacterCoordinates.X = rand_bird.Next(700) * b_rand01;
                CharacterCoordinates.Y = rand_bird.Next(350) * (1 - b_rand01);
                dx1 = (MilkCoordinate.X - CharacterCoordinates.X) / 1000;
                dy1 = (MilkCoordinate.Y - CharacterCoordinates.Y) / 1000;
            }
            if (type == 2)
            {
                Random rand_snake = new Random(DateTime.Now.Second);
                int s_rand01 = rand_snake.Next() % 2;
                CharacterCoordinates.X = rand_snake.Next(350) * s_rand01;
                CharacterCoordinates.Y = rand_snake.Next(200) * (1 - s_rand01);
                dx2 = (MilkCoordinate.X - CharacterCoordinates.X) / 1000;
                dy2 = (MilkCoordinate.Y - CharacterCoordinates.Y) / 1000;
            }
        }

        public void move()
        {
            CharacterCoordinates.X += dx;
            CharacterCoordinates.Y += dy;
        }

        public void move_bird()
        {
            CharacterCoordinates.X += dx1;
            CharacterCoordinates.Y += dy1;
        }

        public void move_snake()
        {
            CharacterCoordinates.X += dx2;
            CharacterCoordinates.Y += dy2;
        }
    }
}