using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Figure
    {
        protected Point[] points = new Point[4];
       
        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
        public void Move(Direction dir)
        {
            foreach (Point p in points)
            {
                p.Move(dir);
            }
        }
    }
}
