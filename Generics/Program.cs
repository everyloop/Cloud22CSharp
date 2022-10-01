PrintFiveTimes("Hello");
Console.WriteLine();
PrintFiveTimes(true);
Console.WriteLine();

Cage<string> stringCage = new("Hello");

Cage<int> intCage = new(3);
intCage.Inhabitant = 5;

DoubleCage<string, bool> doubleCage = new("hej", true);
doubleCage.InhabitantB = false;

Console.WriteLine(stringCage.Inhabitant);
Console.WriteLine(intCage.Inhabitant);
Console.WriteLine(doubleCage.InhabitantA);
Console.WriteLine(doubleCage.InhabitantB);

void PrintFiveTimes<T>(T item)
{
	for (int i = 0; i < 5; i++)
	{
		Console.WriteLine(item);
	}
}

class Cage<T>
{
	public T Inhabitant { get; set; }

	public Cage(T item)
	{
		Inhabitant = item;
	}
}

class DoubleCage<T, T2>
{
	public T InhabitantA { get; set; }
	public T2 InhabitantB { get; set; }

	public DoubleCage(T a, T2 b)
	{
		InhabitantA = a;
		InhabitantB = b;
	}
}
