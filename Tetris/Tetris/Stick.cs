﻿namespace Tetris
{
    internal class Stick : Figure
    {
        public Stick(int x, int y, char c)
        {
            Points[0] = new Point(x, y, c);
            Points[1] = new Point(x, y + 1, c);
            Points[2] = new Point(x, y + 2, c);
            Points[3] = new Point(x, y + 3, c);
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
            for (int i = 0; i < pList.Length; i++)
            {
                pList[i].X = pList[0].X;
                pList[i].Y = pList[0].Y + i;
            }
        }

        private void RotateHorisontal(Point[] pList)
        {
            for (int i = 0; i < pList.Length; i++)
            {
                pList[i].Y = pList[0].Y;
                pList[i].X = pList[0].X + i;
            }
        }
    }
}