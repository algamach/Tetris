using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    static class Field
    {
        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Console.SetWindowSize(_width, HEIGHT);
                Console.SetBufferSize(_width, HEIGHT);
            }
        }

        private static int _width = 40;
        public const int HEIGHT = 30;
           
        public static int GetWidth()
        {
            return _width;
        }

        internal static void SetWidth(int value)
        {
            _width = value;
            Console.SetWindowSize(_width, HEIGHT);
            Console.SetBufferSize(_width, HEIGHT);
        }
    }
}
