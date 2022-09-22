// Eftersom int är en value type så lagras värdet 5 direkt i variabel intA
int intA = 5;

// Detta kopierar värdet (5) från intA till intB
int intB = intA;

// Om vi sedan ändrar värdet på intA, så påverkas inte värdet i intB
intA = 7;

Console.WriteLine($"intA = {intA}");
Console.WriteLine($"intB = {intB}");


// Eftersom Cat är en referenstype så lagrar den en referens till ett Cat-objekt (med namn Felix)
Cat catA = new Cat() { Name = "Felix" };

// Detta kopierar referensen från catA till catB, så catB pekar på samma Cat-objekt (Felix)
Cat catB = catA;

// Om vi sedan ändrar värdet på vårt (enda) objekts namn ...
catA.Name = "Findus";

// Så kommer catA.Name vara samma som catB.Name, eftersom båda är (referens till) samma objekt.
Console.WriteLine($"catA.Name = {catA.Name}");
Console.WriteLine($"catB.Name = {catB.Name}");

// Demoklass:
public class Cat
{
	public string Name;
}