// See https://aka.ms/new-console-template for more information

Dictionary<string, string> countries = new Dictionary<string, string>();

countries.Add("Sverige", "Sweden");
countries.Add("Norge", "Norway");
countries.Add("Danmark", "Denmark");
countries.Add("Finland", "Finland");
countries.Add("Island", "Iceland");

Console.Write("Skriv in ett land: ");
string userInput = Console.ReadLine();

if (countries.TryGetValue(userInput, out string result))
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Country not found!");
}

if (countries.ContainsKey(userInput))
{
    Console.WriteLine(countries[userInput]);
}
else
{
    Console.WriteLine("Country not found!");
}

Console.WriteLine();

foreach (string country in countries.Keys)
{
    Console.WriteLine(country);
}

Console.WriteLine();

foreach (string country in countries.Values)
{
    Console.WriteLine(country);
}

Console.WriteLine();

foreach (KeyValuePair<string, string> country in countries)
{
    Console.WriteLine($"{country.Key} = {country.Value}");
}

Console.WriteLine();

Dictionary<string, User> users = new Dictionary<string, User>() {
    {"fredrik", new User() { Username = "Fredrik", Fullname = "Fredrik Johansson", Password = "abc123" } },
    {"kalle", new User() { Username = "kalle", Fullname = "Karl Johansson", Password = "qwerty" } },
    {"pelle", new User() { Username = "pelle", Fullname = "Pelle Karlsson", Password = "zxc" } }
};

string username = String.Empty;

do
{
    Console.Write("Enter username: ");
    username = Console.ReadLine().ToLower();

    if (users.ContainsKey(username))
    {
        User user = users[username];
        Console.WriteLine($"User: {user.Username}");
        Console.WriteLine($"Password: {user.Password}");
        Console.WriteLine($"Fullname: {user.Fullname}");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("User not found!\n");
    }


} while (username != String.Empty);

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Fullname { get; set; }
}