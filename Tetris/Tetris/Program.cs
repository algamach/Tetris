<<<<<<< Updated upstream
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Tetris!!!");
=======
﻿namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure[] f = new Figure[2];
            f[0] = new Square(2, 5, 'o');
            //f[1] = new Stick(1, 1, '*');

            f[0].Draw();
            f[0].Move(Direction.DOWN);
            f[0].Draw();

            Console.ReadLine();
        }
    }
}
>>>>>>> Stashed changes
