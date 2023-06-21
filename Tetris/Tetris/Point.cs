namespace Tetris
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char C { get; set; }

        private Point point;

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(C);
            Console.SetCursorPosition(0, 0);
        }
        internal void Hide()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(" ");
        }
        internal void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.DOWN:
                    Y += 1;
                    break;
                case Direction.UP:
                    Y -= 1;
                    break;
                case Direction.LEFT:
                    X -= 1;
                    break;
                case Direction.RIGHT:
                    X += 1;
                    break;
            }
        }
        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            C = p.C;
        }
        public Point(int a, int b, char sym)
        {
            X = a;
            Y = b;
            C = sym;
        }

    }
}
