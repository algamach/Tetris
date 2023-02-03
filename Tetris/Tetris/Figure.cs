using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
	internal abstract class Figure
	{
		const int LENGTH = 4;
		protected Point[] points = new Point[LENGTH];
	   
		public void Draw()
		{
			foreach (Point p in points)
			{
				p.Draw();
			}
		}
		public void Hide()
		{
			foreach (Point p in points)
			{
				p.Hide();
			}
		}
		
		//public void Move(Direction dir)
		//{
		//    Hide();
		//    foreach (Point p in points)
		//    {
		//        p.Move(dir);
		//    }
		//    Draw();
		//}
		internal void TryMove(Direction dir)
		{
			Hide();
			var clone = Clone();
			Move(clone, dir);
			if (VirufyPosition(clone))
				points = clone;
			Draw();
		}

		private bool VirufyPosition(Point[] pList)
		{
			foreach(var p in pList)
			{
				if (p.x < 0 || p.y < 0 || p.x >= 40 || p.y >= 29)
					return false;
			}
			return true;
		}

		private void Move(Point[] pList, Direction dir)
		{
			foreach (var p in pList)
			{
				p.Move(dir);
			}
		}

		private Point[] Clone()
		{
			var newPoints = new Point[LENGTH];
			for (int i = 0; i<LENGTH; i++)
			{
				newPoints[i] = new Point(points[i]);
			}
			return newPoints;
		}
		public abstract void Rotate();

	}
}
