//Animal myAnimal = new Animal() { Name = "animal", Age = 0 };

//myAnimal.Speak();

//Animal myCat = new Cat();

//myCat.Speak();

Animal myCat = new Cat() { Name = "Felix" };
Animal myDog = new Dog() { Name = "Karo" };
Animal me = new Human() { Name = "Fredrik " };
SpeakFiveTimes(myCat);
Console.WriteLine();
SpeakFiveTimes(myDog);
Console.WriteLine();
SpeakFiveTimes(me);

Console.WriteLine();

Console.WriteLine(myCat);
Console.WriteLine(myDog);
Console.WriteLine(me);

void SpeakFiveTimes(Animal animal)
{
    for (int i = 0; i < 5; i++)
    {
        animal.Speak();
    }
}

abstract class Animal
{
    public static int Age { get; set; }

    public virtual string Name { get; set; }

    public abstract void Speak();

}

//class Mammal : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("I'm an undefined mammal.");
//    }
//}

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
}