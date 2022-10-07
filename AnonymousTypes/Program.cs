

var anonymous = new { x = 5, y = 0.34f, z = 100L, name = "Fredrik" };

//Console.WriteLine(anonymous.name);

var people = new[] {
      new { LastName = "Eriksson",  FirstName = "Anders", Age = 39 },
      new { LastName = "Palm", FirstName = "Lisa",  Age = 40 },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 31 },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66 },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65 },
};

foreach (var person in people)
{
    Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");
}

Console.WriteLine();

var user = new
{
    name = "Anders Eriksson",
    age = 45,
    contactInfo = new { eMail = "anders@gmail.com", phone = "07023485734" }
};

Console.WriteLine(user.contactInfo.eMail);


