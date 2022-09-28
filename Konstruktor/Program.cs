// See https://aka.ms/new-console-template for more information

Car myCar = new Car("Volvo");

Console.WriteLine(myCar.Name);

Vehicle myVehicle = new Vehicle("test");
enum CarColor
{
    Black,
    White,
    Red,
    Blue,
    Undefined
}

class Vehicle
{
    public string Name { get; set; }

    public Vehicle(string name)
    {
        Name = name;
    }
}

class Car : Vehicle
{
    public string Maker { get; set; }
    public string Model { get; set; }
    public int ProductionYear { get; set; }
    public CarColor Color { get; set; }

    public Car() : this(String.Empty)
    {
    }

    public Car(string maker) : this(maker, String.Empty)
    {
    }
    public Car(string maker, string model) : this(maker, model, -1)
    {
    }

    public Car(string maker, string model, int productionYear) : this("Tesla", model, productionYear, CarColor.Undefined)
    {
    }

    public Car(string maker, string model, int productionYear, CarColor color) : base(maker)
    {
        Maker = maker;
        Model = model;
        ProductionYear = productionYear;
        Color = color;
    }

}