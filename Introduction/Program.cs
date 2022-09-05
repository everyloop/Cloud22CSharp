
//Datatyper:
// string  -> Text
// char    -> Ett tecken
// int     -> Heltal (integer) 32 - bitars - minus ~2.1 miljarder till plus ~2.1 miljarder
// long    -> Heltal (integer) 64 - bitars
// bool    -> Sant / Falskt
// float   -> Decimaltal(flyttal 32 - bitars)
// double  -> Decimaltal(flyttal 64 - bitars)


// Jämförelser:
// Lika med:                ==
// Inte lika med            !=
// Mindre än                <
// Mindre än eller lika     <=
// Större än                >
// Större än eller lika     >=


// Exempel med if-sats
/* 
Console.Write("Enter your name: ");

string name = Console.ReadLine();

if (name == "Fredrik")
{
    Console.Clear();
    // Concatenate
    Console.WriteLine("Hej " + name);
}
else if (name == "Philip")
{
    Console.WriteLine("Tjena " + name);
}
else if (name == "Marcus")
{
    Console.WriteLine("Hejsan Marcus!");
}
else
{
    int talA = 5;
    int talB = 3;

    Console.WriteLine($"{talA}+{talB}={talA + talB}");
}
*/



// Exempel på iterationer (loopar)


// While loop körs så länge uttrycket (name != exit) är sant.
/*
string name = "";

while (name != "exit")
{
    Console.Clear();
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
    Console.WriteLine("Hej " + name);
    Console.WriteLine("Press any key to continue!");
    Console.ReadKey();
}
*/

// While-loop som skriver ut 123456789
/*
int i = 1;

while (i < 10)
{
    Console.Write(i);
    i = i + 1;
}
*/

// Miniuppgift, gör ett program som skriver ut: 987654321
for (int i = 9; i > 0; i--)
{
    Console.Write(i);
}
Console.WriteLine();

// Alternativ lösning 1
/*
for (int i = 9; i >= 1; i--)
{
    Console.Write(i);
}
Console.WriteLine();
*/

/* Alternativ lösning 2
for (int i = 0; i < 9; i++)
{
    Console.Write(9-i);
}
Console.WriteLine();
*/

// Miniuppgift 2, gör ett program som frågar efter ett Namn, och sedan skriver ut det 10 gånger.

Console.Write("Skriv ditt Namn: ");
var name = Console.ReadLine();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(name);
}

