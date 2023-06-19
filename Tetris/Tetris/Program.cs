namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Field.GetWidth(), Field.HEIGHT);
            Console.SetBufferSize(Field.GetWidth(), Field.HEIGHT);

            Field.SetWidth(20);

            FigureGenerator generator = new FigureGenerator(Field.GetWidth()/2, 0, 'O');

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


                case ConsoleKey.UpArrow:
                    currentFigure.TryMove(Direction.UP);
                    break;

                case ConsoleKey.Spacebar:
                    currentFigure.Hide();
                    currentFigure.TryRotate();
                    currentFigure.Draw();

                    break;

            }
        }
    }
}
