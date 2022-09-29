// See https://aka.ms/new-console-template for more information

List<string> countries = new List<string>();

countries.Add("Sweden");
countries.Add("Norway");

countries.Clear();

countries.Add("Denmark");
countries.Add("Finland");
countries.Add("Iceland");

countries.AddRange(new string[] { "Spain", "France", "Italy", "Germany", "Ireland", "Poland" });

countries.Remove("Finland");
countries.RemoveAt(1);

countries.RemoveRange(3, 2);

countries.Insert(1, "Croatia");

Console.WriteLine(countries.Contains("Spain") ? "Yes!" : "Nope! :(");

//Console.WriteLine("Hello world!".Contains("world") ? "Yes!" : "Nope! :(");

Console.WriteLine($"Index of Spain: {countries.IndexOf("Spain")}");

List<string> strings = countries.ToArray().ToList<string>();

countries.Sort();
countries.Reverse();

Console.WriteLine(String.Join("\n", countries));
Console.WriteLine();

foreach (string country in countries)
{
    Console.WriteLine(country);
}
Console.WriteLine();

for (int i = 0; i < countries.Count; i++)
{
    Console.WriteLine(countries[i]);
}