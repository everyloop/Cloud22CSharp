// Deklarera en array av datatypen int och initiera med en rad värden.
int[] myIntArray = { 5, 6, 10, 12, 14, 1, 8, 2, 2 };

// Arrayer har en property .Length som ger er längden på arrayen
for (int i = 0; i < myIntArray.Length; i++)
{
    // Vi kommer åt värdet på enskilda element genom att ange ett index i hakparanteser
    Console.WriteLine(myIntArray[i]);
}

Console.WriteLine();


foreach (var item in myIntArray)
{
    // Med foreach behöver man inte använda något index för att komma åt varje enskilt element.
    // Tänk på att foreach inte kan användas för att uppdatera elementen i en array.
    Console.WriteLine(item * 2);
}

Console.WriteLine();


// Namnet på listor och arrayer bör vara i plural då det beskriver flera av något
string[] cities = { "Stockholm", "Göteborg", "Borås" };

// Variabeln city representerar varje enskilt element i arrayen cities.
foreach (string city in cities)
{
    Console.WriteLine(city);
}


Console.WriteLine();

string text = "Detta är en text";

// En sträng fungerar likt en array av datatyp char.
// Man kan därför loop igenom varje tecken med foreach:
foreach (char character in text)
{
    Console.Write(character);
}

Console.WriteLine();

// Man kan även indexera enskilda tecken i en string:
char firstCharacter = text[0];
char lastCharacter = text[text.Length - 1];

Console.WriteLine($"{firstCharacter} -> {lastCharacter}");