using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = int.Parse(Console.ReadLine());
            var k = 0;
            if (input > 1)
            {
                while (input > 2)
                {
                    input /= 2;
                    k++;
                }
                if (input > 0)
                {
                    k++;
                }
                Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}