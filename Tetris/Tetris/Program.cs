namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            FigureGenerator generator = new FigureGenerator(20, 0, 'O');
            Figure currentFigure = generator.GetNewFigure();

            while (true)
            {            
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();    //ConsoleKeyInfo
                    HandleHey(currentFigure, key);


                }
            }        
        }

        private static void HandleHey(Figure currentFigure, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currentFigure.TryMove(Direction.LEFT);
                    break;

                case ConsoleKey.RightArrow:
                    currentFigure.TryMove(Direction.RIGHT);
                    break;

                case ConsoleKey.DownArrow:
                    currentFigure.TryMove(Direction.DOWN);
                    break;

            }
        }
    }
}
