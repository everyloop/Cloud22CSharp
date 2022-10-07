// See https://aka.ms/new-console-template for more information

Artist myArtist = Leo;
Artist myOtherArtist = new Artist(Leo);

DrawFivePaintings("pineapple", Pico);
Console.WriteLine();
DrawFivePaintings("pineapple", Leo);
/*
myArtist?.Invoke("orange"
myArtist?.Invoke("apple");

myOtherArtist?.Invoke("mango");
myOtherArtist?.Invoke("melon");
*/
/*
ArtistMultiplePaintings multiplePaintings = Goya;

multiplePaintings("pear", 4);
*/



void DrawFivePaintings(string text, Artist artist)
{
    string s = String.Empty;
    for (int i = 0; i < 5; i++)
    {
        s += artist(text) + '\n';
    }

    Console.WriteLine(s);
}

string Pico(string text)
{
    return $"Pico painted: {text}";
}

string Leo(string text)
{
    return $"Leo painted: {text}";
}

void Goya(string text, int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine($"Goya painted: {text}");
    }
}

public delegate string Artist(string text);
public delegate void ArtistMultiplePaintings(string s, int n);