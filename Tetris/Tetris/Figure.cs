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
        public abstract void Rotate(Point[] pList);

        internal Result TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;

            Draw();

            return result;
        }

        private Result VerifyPosition(Point[] newPoints)
        {
            foreach (var p in newPoints)
            {
                //in theory it shouldn't be here -1     
                if (p.Y >= Field.Height-1)
                    return Result.DOWN_BORDER_STRIKE;
                if (p.X >= Field.Width || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRIKE;
                if (Field.CheckStrike(p))
                    return Result.HEAP_STRIKE;
            }
            return Result.SUCCESS;
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

        internal Result TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;

            Draw();
            return result;
        }
    }
}
