// See https://aka.ms/new-console-template for more information

ConsoleColor myColor = Console.ForegroundColor;

Console.WriteLine(true);

Console.ForegroundColor = ConsoleColor.Red;

Console.Write("Röd");

int xPos = Console.CursorLeft;

Console.WriteLine(xPos);

Console.ForegroundColor = myColor;

Console.WriteLine("The End!");

