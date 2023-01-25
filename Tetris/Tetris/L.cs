using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class L : Figure
    {
        
        public L(int x, int y, char c)
        {
            points[0] = new Point(x, y, c);
            points[1] = new Point(x, y+1 , c);
            points[2] = new Point(x, y+2, c);
            points[3] = new Point(x + 1, y + 2, c);
            Draw();
        }
        public override void Rotate()
        {
            if (points[0].x == points[1].x)
            {
                RotateHorisontal();
            }
            else
            {
                RotateVertical();
            }

        }

        private void RotateVertical()
        {
            for (int i = 0; i < points.Length-1; i++)
            {
                points[i].x = points[0].x;
                points[i].y = points[0].y + i;
            }
            points[3].x= points[2].x+1;
            points[3].y = points[2].y;
        }

        private void RotateHorisontal()
        {
            for (int i = 0; i < points.Length-1; i++)
            {
                points[i].y = points[0].y;
                points[i].x = points[0].x + i;
            }
            points[3].y = points[2].y-1;
            points[3].x = points[2].x;
        }
    }
}
