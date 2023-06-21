﻿namespace Tetris
{
    static class Field
    {
        private static int _width = 40;
        private static int _height = 30;
        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Console.SetWindowSize(_width, _height);
                Console.SetBufferSize(_width, _height);
            }
        }
        public static int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Console.SetWindowSize(_width, _height);
                Console.SetBufferSize(_width, _height);
            }
        }

        private static bool[][] _heep;

        static Field()
        {
            _heep = new bool[Height][];
            for (int i = 0; i < Height; i++)
            {
                _heep[i] = new bool[Width];
            }
        }
        public static bool CheckStrike(Point p)
        {
            return _heep[p.Y][p.X];
        }
        public static void AddFigure(Figure fig)
        {
            foreach (var p in fig.Points)
            {
                _heep[p.Y][p.X] = true;
            }
        }
    }
}
