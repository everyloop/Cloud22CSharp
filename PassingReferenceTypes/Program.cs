// Eftersom Cat är en value type så lagras referens till Cat-objektet i myCat
Cat myCat = new Cat() { Name = "Findus" };
Console.WriteLine($"myCat.Name = {myCat.Name}");

// När vi anropar PassByValue() så kopieras referensed från myCat till den nya variabeln cat
PassByValue(myCat);

// PassByValue kan därför aldrig ändra vilket objekt myCat refererar till, även om kopian (number) ändras.
Console.WriteLine($"myCat.Name = {myCat.Name}");

// När vi anropar PassByReference() så blir cat en referens till myCat
PassByReference(ref myCat);

// ... vilket betyder att om metoden pekar cat mot ett nytt objekt så ändras även referensen på myCat
Console.WriteLine($"myCat.Name = {myCat.Name}");

// Notera dock att pass by value inte hindrar metoden från att ändra egenskaper på objektet.
PassByValueButChangeProperty(myCat);

// Eftersom cat och myCat är referenser till samma objekt så är förstås även myCat.Name ändrat nu.
Console.WriteLine($"myCat.Name = {myCat.Name}");




// Pass by value är standardsättet att skicka argument till metoder
void PassByValue(Cat cat)
{
	cat = new Cat() { Name = "Felix" };
	Console.WriteLine($"PassByValue(): cat.Name = {cat.Name}");
}

// När man markerar en parameter med "ref" så kommer argumentet skickas "pass by referens"
void PassByReference(ref Cat cat)
{
	cat = new Cat() { Name = "Felix" };
	Console.WriteLine($"PassByReference(): cat.Name = {cat.Name}");
}

void PassByValueButChangeProperty(Cat cat)
{
	cat.Name = "newName";
	Console.WriteLine($"PassByValueButChangeProperty(): cat.Name = {cat.Name}");
}




// Demoklass:
public class Cat
{
	public string Name;
}