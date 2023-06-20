using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal abstract class Figure
    {
        const int LENGTH = 4;
        public Point[] Points = new Point[LENGTH];
       
        public void Draw()
        {
            foreach (Point p in Points)
            {
                p.Draw();
            }
        }
        public void Hide()
        {
            foreach (Point p in Points)
            {
                p.Hide();
            }
        }
        /*public void Move(Direction dir)
        {
            Hide();
            foreach (Point p in points)
            {
                p.Move(dir);
            }
            Draw();
        }*/
        public abstract void Rotate(Point[] pList);

        internal void TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);
            if (VerifyPosition(clone))
                Points = clone;
            Draw();
        }

        private bool VerifyPosition(Point[] pList)
        {
            foreach (var p in pList)
            {
                if (p.X < 0 || p.Y < 0 || p.X >= Field.Width || p.Y >= Field.Height - 1)

                    return false;
            }
            return true;
        }

        public void Move(Point[] pList, Direction dir)
        {            
            foreach (var p in pList)
            {
                p.Move(dir);
            }
        }

        private Point[] Clone()
        {
            var newPonits = new Point[LENGTH];
            for (int i = 0; i<LENGTH; i++)
            {
                newPonits[i] = new Point(Points[i]);
            }
            return newPonits;
        }

        internal void TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);
            if (VerifyPosition(clone))
                Points = clone;
            Draw();
        }
    }
}
