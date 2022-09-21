// See https://aka.ms/new-console-template for more information

Person fredrik = new Person("Fredrik", "Johansson");
Person anna = new("Anna");

Console.WriteLine(fredrik.Name);
Console.WriteLine(anna.Name);

//fredrik.SetLength(0.80);
//anna.SetLength(1.72);

fredrik.Length = 1.80;

Console.WriteLine(fredrik.Length.ToString() + " cm");

public class Person
{
    public string Name = String.Empty;
    public static string Type = "Human";

    private double length;
    public double Length
    {
        get { return this.length; }
        set { this.length = Math.Clamp(value, 1.0, 2.0); }
    }

    public Person(string firstName, string lastName)
    {
        Name = firstName + " " + lastName;

        if (Name == "Fredrik Johansson")
        {
            Name = "The Great " + Name;
        }
    }

    public Person(string firstName)
    {
        Name = firstName + " Unknown";
    }

    public void SetLength(double length)
    {
        this.length = Math.Clamp(length, 1.0, 2.0);
    }

    public double GetLength()
    {
        return this.length;
    }
}