namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure[] f = new Figure[2];
            f[0] = new Stick(7, 5, 'o');
            //f[1] = new Stick(1, 1, '*');

            f[0].Draw();

            Thread.Sleep(500);
            f[0].Hide();
            f[0].Move(Direction.DOWN);
            f[0].Draw();

            Thread.Sleep(500);
            f[0].Hide();
            f[0].Rotate();
            f[0].Draw();

            Thread.Sleep(500);
            f[0].Hide();
            f[0].Move(Direction.DOWN);
            f[0].Draw();

            Thread.Sleep(500);
            f[0].Hide();
            f[0].Move(Direction.DOWN);
            f[0].Draw();

            Thread.Sleep(500);
            f[0].Hide();
            f[0].Move(Direction.DOWN);
            f[0].Draw();

            Thread.Sleep(500);
            f[0].Hide();
            f[0].Rotate();
            f[0].Draw();

            Thread.Sleep(500);
            f[0].Hide();
            f[0].Move(Direction.DOWN);
            f[0].Draw();

            Thread.Sleep(500);
            f[0].Hide();
            f[0].Move(Direction.DOWN);
            f[0].Draw();

            Thread.Sleep(500);
            f[0].Hide();
            f[0].Move(Direction.DOWN);
            f[0].Draw();
            Console.ReadLine();
        }
    }
}
