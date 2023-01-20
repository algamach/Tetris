﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Point
    {
        public int x;
        public int y;
        public char c;
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(c);
        }

        internal void Move(Direction dir)
        {
            switch(dir)
            {
                case Direction.DOWN:
                    y += 1;
                    break;
                case Direction.LEFT:
                    x -= 1;
                    break;
                case Direction.RIGHT:
                    x += 1;
                    break;


            }
        }

        public Point() { }
        public Point(int a, int b, char sym)
        {
            x = a;
            y = b;
            c = sym;
        }
    }
}