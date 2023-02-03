using System;
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
            Console.SetCursorPosition(0, 0);
        }
        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");
        }
        internal void Move(Direction dir)
        {
            switch(dir)
            {
                case Direction.UP:
                    y -= 1;
                    break;
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
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            c = p.c;
        }
        public Point(int a, int b, char sym)
        {
            x = a;
            y = b;
            c = sym;
        }
    }
}
