ConsoleKey key;

int width = 15;
int height = 10;
DrawBox(width, height);

Console.CursorVisible = false;

Player player1 = new Player(2, 2, 'A');
Player player2 = new Player(5, 6, 'B');

do
{
    key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.LeftArrow)
    {
        player1.X--;
        player2.X--;
    }

    if (key == ConsoleKey.RightArrow)
    {
        player1.X++;
        player2.X++;
    }

    if (key == ConsoleKey.UpArrow)
    {
        player1.Y--;
        player2.Y--;
    }
    if (key == ConsoleKey.DownArrow)
    {
        player1.Y++;
        player2.Y++;
    }
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

public class Player
{
    private char playerCharacter;

    private int _x = 5;
    public int X
    {
        get { return _x; }
        set { 
            if (_x != value)
            {
                RemovePlayer();
                _x = Math.Clamp(value, 1, 13);
                DrawPlayer();
            }
        }
    }

    private int _y = 2;
    public int Y
    {
        get { return _y; }
        set {
            if (_y != value)
            {
                RemovePlayer();
                _y = Math.Clamp(value, 1, 8);
                DrawPlayer();
            }
        }
    }

    public Player(int startX, int startY, char playerCharacter = 'O')
    {
        _x = Math.Clamp(startX, 1, 13);
        _y = Math.Clamp(startY, 1, 8);
        this.playerCharacter = playerCharacter;
        DrawPlayer();
    }
    private void RemovePlayer()
    { 
        Console.SetCursorPosition(X, Y);
        Console.Write("-");
    }

    private void DrawPlayer()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write(playerCharacter);
    }

}