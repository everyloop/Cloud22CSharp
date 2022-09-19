
class Cat
{
    public string Name = String.Empty;
    private int Age = 1;
    
    // Konstruktor
    public Cat(string name)
    {
        this.Name = name;
    }

    public Cat(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void Greeting()
    {
        Greeting("Hello");
    }
     
    public void Greeting(string greeting)
    {
        Console.WriteLine($"{greeting}, my name is {Name}");
        PrintAge();
    }

    private void PrintAge()
    {
        Console.WriteLine($"I'm {Age} years old.");
    }

    public void AgeOneYear()
    {
        Age++;
    }
}

// Skriv en klass "Dog" som har publika fält (fields) Name, Breed, Weight.
// Skapa sedan två instanser, sätt olika värden på fälten och skriv ut dem i Consolen.