// See https://aka.ms/new-console-template for more information

Person fredrik = new() { Name = "Fredrik" };
Person joel = new() { Name = "Joel" };
Person adam = new() { Name = "Adam" };


// Null coalescing operator: 
//fredrik.BestFriend = joel ?? adam ?? fredrik;

adam ??= joel;

//adam = adam ?? joel;

/*
fredrik.BestFriend = joel;
joel.BestFriend = null;
adam.BestFriend = fredrik;
*/

// Null conditional operator:   ?.  ?[]
Console.WriteLine(adam.Name);

/*
Person[] persons = new Person[10];

Console.WriteLine(persons?[2]?.Name);
*/


class Person
{
    public string Name { get; set; }
    public Person BestFriend { get; set; }
}


/* Nullable value types
int? myInt = 5;

if (myInt is not null)
{
    Console.WriteLine($"myInt has value: {myInt}");
}

if (myInt.HasValue)
{
    Console.WriteLine($"myInt has value: {myInt.Value}");
}
else
{
    Console.WriteLine("myInt has no value!");
}
*/