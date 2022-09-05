// See https://aka.ms/new-console-template for more information
int x1 = 5;
int x2 = 8;

// Absolutbelopp (returnerar positivt tal) 
Console.WriteLine("Abs(8-5): " + Math.Abs(x2-x1));
Console.WriteLine();

// Avrundning
Console.WriteLine("Floor(3.4f): " + Math.Floor(3.4f));    // Närmsta heltal "neråt"
Console.WriteLine("Ceiliing(3.4f): " + Math.Ceiling(3.4f));  // Närmsta heltal "uppåt"
Console.WriteLine("Round(3.4f): " + Math.Round(3.4f));    // Närmsta heltal
Console.WriteLine("Truncate(3.4f): " + Math.Truncate(3.4f)); // Tar ut heltals delen av en double/float
Console.WriteLine();

// Min, Max, Clamp
Console.WriteLine("Min(5, 8): " + Math.Min(5, 8));
Console.WriteLine("Max(5, 8): " + Math.Max(5, 8));
Console.WriteLine("Clamp(5, 0, 100): " + Math.Clamp(5, 0, 100));
Console.WriteLine();

// Power, Square root
Console.WriteLine("Pow(2, 4): " + Math.Pow(2, 4));  // 2^4, 2 upphöjt till 4 
Console.WriteLine("Sqrt(9): " + Math.Sqrt(9)); // Kvadratroten ur 9




