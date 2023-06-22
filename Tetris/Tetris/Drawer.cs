namespace Tetris
{
    public static class Drawer
    {
        public const char DEFAUTL_SYMBOL = '*';
        public static void DrawPoint(int x, int y, char c = DEFAUTL_SYMBOL)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
            Console.SetCursorPosition(0, 0);
        }
        public static void HidePoint(int x, int y)
        {

            Console.SetCursorPosition(x, y);
            Console.Write(' ');
            Console.SetCursorPosition(0, 0);
        }
    }
}