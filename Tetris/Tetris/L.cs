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
        public override void Rotate(Point[] pList)
        {
            if (pList[0].x == pList[1].x)
            {
                RotateHorisontal(pList);
            }
            else
            {
                RotateVertical(pList);
            }

        }

        private void RotateVertical(Point[] pList)
        {
            for (int i = 0; i < pList.Length-1; i++)
            {
                pList[i].x = pList[0].x;
                pList[i].y = pList[0].y + i;
            }
            pList[3].x= pList[2].x+1;
            pList[3].y = pList[2].y;
        }

        private void RotateHorisontal(Point[] pList)
        {
            for (int i = 0; i < pList.Length-1; i++)
            {
                pList[i].y = pList[0].y;
                pList[i].x = pList[0].x + i;
            }
            pList[3].y = pList[2].y-1;
            pList[3].x = pList[2].x;
        }
    }
}
