var people = new[] {
      new { LastName = "Eriksson",  FirstName = "Anders", Age = 39 },
      new { LastName = "Palm", FirstName = "Lisa",  Age = 40 },
      new { LastName = "Andersson",  FirstName = "Per",  Age = 31 },
      new { LastName = "Lundberg",  FirstName = "Anna",  Age = 66 },
      new { LastName = "Eriksson",  FirstName = "Camilla",  Age = 65 },
};

/*
var filteredArray = people
                        .Where(p => p.FirstName.Length == 4 || p.LastName.Length == 4 )
                        .Select(p => new { 
                            Name = $"{p.FirstName} {p.LastName}", 
                            UserName = (p.FirstName.Substring(0, 3) + p.LastName.Substring(0, 3)).ToLower()
                        } )
                        //.Where(p => p.Name.Length < 10)
                        .ToList();
*/

var filteredArray = from p in people
                    where p.FirstName.Length == 4 || p.LastName.Length == 4
                    select new
                    {
                        Name = $"{p.FirstName} {p.LastName}",
                        UserName = (p.FirstName.Substring(0, 3) + p.LastName.Substring(0, 3)).ToLower()
                    };

foreach (var person in filteredArray)
{
    Console.WriteLine(person);
}
