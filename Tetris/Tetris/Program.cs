namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            FigureGenerator generator = new FigureGenerator(20, 0, 'O');
            Figure s;

            while (true)
            {                
                FigureFall(out s, generator);
                s.Draw();
            }
            static void FigureFall(out Figure fig, FigureGenerator generator)
            {                
                fig = generator.GetNewFigure();
                fig.Draw();

                for (int i=0; i<15; i++)
                {
                    fig.Hide();
                    fig.Move(Direction.DOWN);
                    fig.Draw();
                    Thread.Sleep(200); 

                }
            }


            s.Draw();
            Thread.Sleep(500);
            s.Hide();
                       
            s.Move(Direction.DOWN);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();

            s.Move(Direction.DOWN);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();

            s.Move(Direction.DOWN);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();

            s.Move(Direction.DOWN);
            s.Draw();
            Thread.Sleep(500);
            

            s = generator.GetNewFigure();

            s.Draw();
            Thread.Sleep(500);
            s.Hide();

            s.Move(Direction.RIGHT);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.RIGHT);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.RIGHT);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.RIGHT);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();

            s.Move(Direction.DOWN);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();

            s.Move(Direction.DOWN);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();

            s.Move(Direction.DOWN);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();

            s.Move(Direction.DOWN);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();

            s.Move(Direction.DOWN);
            s.Draw();
            Thread.Sleep(500);
            
        }
    }
}
