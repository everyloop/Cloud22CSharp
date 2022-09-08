// See https://aka.ms/new-console-template for more information

// PascalCase för namn på metoder och funktioner
// camelCase för namn på lokal variabler och paramaterar

//PrintGreetingMultipleTimes("Fredrik");
PrintGreetingMultipleTimes(name: "Kalle", numberOfTimesToPrint: 5, printExclamationMark: true);


// Lägg till så att metoden skriver ut '!!!" i slutet på varje rad om printExclamationMark är true.
void PrintGreetingMultipleTimes(string name = "default", int numberOfTimesToPrint = 0, bool printExclamationMark = false)
{
	string lineEnding = String.Empty;
	if (printExclamationMark)
	{
		lineEnding = "!!!";
	}

	for (int i = 0; i < numberOfTimesToPrint; i++)
	{
		Console.WriteLine($"Hello, {name}{lineEnding}");
	}
}



int AddFive(int number)
{
	return number + 5;
}

int Sum(bool multiplyInstead, params int[] numbers)
{
	int sum = 0;

	if (multiplyInstead)
	{
		sum = 1;
	}

	foreach (int number in numbers)
	{
		if (multiplyInstead)
		{
			sum *= number;
		}
		else
		{
			sum += number;
		}
	}
	return sum;
}

int[] myNumbers = { 1, 3, 8, 2 };

int result = Sum(true, 5, 3);
Console.WriteLine(result);


int myIf(bool returnA, int a, int b)
{
	if (returnA)
	{
		return a;
	}

	return b;
}

Console.WriteLine(myIf(5 < 3, 3, 5));


