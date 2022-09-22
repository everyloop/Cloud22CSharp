// Eftersom int är en value type så lagras värdet 2 direkt i variabel myInt
int myInt = 2;
Console.WriteLine($"myInt = {myInt}");

// När vi anropar PassByValue() så kopieras värdet (2) från myInt till en ny variabel number
PassByValue(myInt);

// PassByValue kan därför aldrig ändra värdet på myInt, oavsett vad den gör med kopian (number)
Console.WriteLine($"myInt = {myInt}");

// När vi anropar PassByReference() så blir number en referens till myInt
PassByReference(ref myInt);

// ... vilket betyder att om metoden ändrar värde på number så ändras även värdet på myInt
Console.WriteLine($"myInt = {myInt}");




// Pass by value är standardsättet att skicka argument till metoder
void PassByValue(int number)
{
	number += 5;
	Console.WriteLine($"PassByValue(): number = {number}");
}

// När man markerar en parameter med "ref" så kommer argumentet skickas "pass by referens"
void PassByReference(ref int number)
{
	number += 5;
	Console.WriteLine($"PassByReference(): number = {number}");
}