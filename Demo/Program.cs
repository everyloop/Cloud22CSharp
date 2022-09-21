ConsoleKey key;

int width = 15;
int height = 10;
DrawBox(width, height);

int playerXPos = 5;
int playerYPos = 2;

Console.CursorVisible = false;

Console.SetCursorPosition(playerXPos, playerYPos);
Console.Write("O");

do
{
    key = Console.ReadKey(true).Key;

    Console.SetCursorPosition(playerXPos, playerYPos);
    Console.Write("-");

    if (key == ConsoleKey.LeftArrow && playerXPos > 1)
    {
        playerXPos--;
    }

    if (key == ConsoleKey.RightArrow && playerXPos < width - 2)
    {
        playerXPos++;
    }

    Console.SetCursorPosition(playerXPos, playerYPos);
    Console.Write("O");

} while (key != ConsoleKey.Escape);

void DrawBox(int width, int height)
{
    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
            Console.Write(x == 0 || x == width - 1 || y == 0 || y == height - 1 ? 'X' : '-');
        }
        Console.WriteLine();
    }
}