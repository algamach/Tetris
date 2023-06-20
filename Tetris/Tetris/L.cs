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
            Points[0] = new Point(x, y, c);
            Points[1] = new Point(x, y+1 , c);
            Points[2] = new Point(x, y+2, c);
            Points[3] = new Point(x + 1, y + 2, c);
            Draw();
        }
        public override void Rotate(Point[] pList)
        {
            if (pList[0].X == pList[1].X)
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
                pList[i].X = pList[0].X;
                pList[i].Y = pList[0].Y + i;
            }
            pList[3].X= pList[2].X+1;
            pList[3].Y = pList[2].Y;
        }

        private void RotateHorisontal(Point[] pList)
        {
            for (int i = 0; i < pList.Length-1; i++)
            {
                pList[i].Y = pList[0].Y;
                pList[i].X = pList[0].X + i;
            }
            pList[3].Y = pList[2].Y-1;
            pList[3].X = pList[2].X;
        }
    }
}
