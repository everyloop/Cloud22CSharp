var generatedNumber = GenerateWithoutYield(100000000);

foreach (int item in generatedNumber)
{
	Console.WriteLine(item);
	if (item >= 10) break;
}

Console.WriteLine("The end!");

IEnumerable<int> GenerateWithoutYield(int maxValue)
{
	var i = 0;
	var list = new List<int>();
	while (i < maxValue) list.Add(++i);
	return list;
}

IEnumerable<int> GenerateWithYield(int maxValue)
{
	var i = 0;
	while (i < maxValue)
	{
		i++;
		yield return i;
	}
}