
Animal myCat = new Cat() { Name = "Felix" };
Animal myDog = new Dog() { Name = "Karo" };
Animal me = new Human() { Name = "Fredrik " };
SpeakFiveTimes(myCat);
Console.WriteLine();
SpeakFiveTimes(myDog);
Console.WriteLine();
SpeakFiveTimes(me);
Console.WriteLine();
SpeakFiveTimes(5.3f);


void SpeakFiveTimes(object obj)
{
    for (int i = 0; i < 5; i++)
    {
        /*
        Animal animal = (Animal)obj;
        Animal animal = obj as Animal;

        if (animal is not null)
        {
            animal.Speak();
        }
        */

        if (obj is Animal animal)
        {
            //Animal animal = (Animal)obj;
            animal.Speak();
        }
        else if (obj is float f)
        {
            Console.WriteLine($"Float value: {f}");
        }
    }
}

abstract class Animal
{
    public static int Age { get; set; }

    public virtual string Name { get; set; }

    public abstract void Speak();

}

class Cat : Animal
{
    public static int Age { get; set; }

    public override void Speak()
    {
        Console.WriteLine("I'm a cat!");
    }

    public override string ToString()
    {
        return $"My name is {Name}, and I like milk.";
    }

}

class Dog : Animal
{
    public static int Age { get; set; }

    public override void Speak()
    {
        Console.WriteLine("I'm a dog!");
    }
}

class Human : Animal
{
    public static int Age { get; set; }

    private string _name;

    public float MaxHealth
    {
        get { return 12.0f; }
    }

    public override string Name
    {
        get => $"*** {_name} ***";
        set => _name = value;
    }

    public override void Speak()
    {
        Console.WriteLine("I'm a human!");
    }

    public override string ToString()
    {
        return $"My name is {Name}, and I am a human.";
    }

}