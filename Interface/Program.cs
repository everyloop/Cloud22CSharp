

using (var myCat = new Cat("Felix", 3.1))
{
	Console.WriteLine($"The name of the cat is: {myCat.Name}");
}

Console.WriteLine();

Cat[] cats = {
	new Cat("Felix", 3.4),
	new Cat("Findus", 1.4),
	new Cat("Misse", 2.8),
	new Cat("Kisse", 2.7),
	new Cat("Pisse", 1.9),
};

Array.Sort(cats);

foreach (Cat cat in cats)
{
	Console.WriteLine($"{cat.Name} weights {cat.Weight} kg.");
	if (cat is IExplodable explodable)
	{
		explodable.Explode();
	}

}

class Animal : IExplodable
{
	public double ExplosionVelocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

	public string Name { get; set; }

	public void Explode()
	{
		Console.WriteLine($"{Name} explodes!");
	}
}

class Cat : Animal, IDisposable, IComparable<Cat>
{
	public double Weight { get; set; }

	public Cat(string name, double weight)
	{
		Name = name;
		Weight = weight;
	}

	public void Dispose()
	{
		Console.WriteLine($"{Name} is disposed!");
	}

	public int CompareTo(Cat cat)
	{
		//return Name.CompareTo((obj as Cat).Name);
		return Weight.CompareTo(cat.Weight);
	}
}

interface IExplodable
{
	public double ExplosionVelocity { get; set; }
	public void Explode();
}
