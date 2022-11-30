using EFDemo.data;
using EFDemo.models;

using EveryloopContext db = new();

if (!db.Database.CanConnect())
{
    Console.WriteLine("Could not connect to database!");
    return;
}

var countries = db.Countries.Where(country => country.Cities.Count == 1).ToList();
var cities = db.Cities.ToList();

foreach (var country in countries)
{
    Console.WriteLine(country.Name);

    if (country.Cities is null)
    {
        Console.WriteLine("  -");
        continue;
    }

    foreach (var city in country.Cities)
    {
        Console.WriteLine($"  {city.Name}");
    }

    Console.WriteLine();
}


Console.WriteLine();