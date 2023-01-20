// See https://aka.ms/new-console-template for more information
Console.SetWindowSize(40, 30);
Console.SetBufferSize(40, 30);

int x1 = 2;
int y1 = 3;
char c1 = '*';

Draw(x1, y1, c1);
Draw(8, 19, '#');

Console.ReadLine();
static void Draw(int x,int y,char c)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(c);
    }
 