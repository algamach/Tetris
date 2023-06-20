namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Field.Width, Field.Height);
            Console.SetBufferSize(Field.Width, Field.Height);

            FigureGenerator generator = new FigureGenerator(Field.Width/2, 0, 'O');

            Figure currentFigure = generator.GetNewFigure();

            while (true)
            {            
                if (Console.KeyAvailable)
                {
                    //ConsoleKeyInfo
                    var key = Console.ReadKey();    
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
