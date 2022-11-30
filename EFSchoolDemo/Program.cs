using EFSchoolDemo.Data;

using SchoolContext db = new();

if (!db.Database.CanConnect())
{
    Console.WriteLine("Can not connect to database. :(");    
    return;
}

var courses = db.Courses.ToList();
var students = db.Students.ToList();
var grades = db.Grades.ToList();

Console.WriteLine();