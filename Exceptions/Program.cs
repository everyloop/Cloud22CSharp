// Aritmethic overflow
int maxInt = int.MaxValue;

checked
{
    maxInt++;
    Console.WriteLine(maxInt);
}

// Divide by zero exception
int zero = 0;
Console.WriteLine(1 / zero);

// Stack overflow
MethodA();
void MethodA()
{
    MethodA();
}

// Out of memory exception
int[] myArray = new int[2000000000];
int[] myArray2 = new int[2000000000];
int[] myArray3 = new int[2000000000];
int[] myArray4 = new int[2000000000];

// Null reference exception
string myString = null;
Console.WriteLine(myString.ToUpper());

// Format Exception
int myInt = Int32.Parse("hej");

// Index out of range
int[] arr = { 5, 6, 4 };
Console.WriteLine(arr[5]);

//bool doLoop = true;

//while (doLoop)
//{
//    myMethod();
//}

//void myMethod()
//{
//    try
//    {
//        Console.Write("Enter a number: ");

//        var num = int.Parse(Console.ReadLine());

//        Console.WriteLine($"Squre of {num} is {num * num}");
//        doLoop = false;
//    }
//    catch
//    {
//        Console.WriteLine("Not a valid number!");
//        myMethod();
//    }
//}

//String std = null;

//try
//{
//    PrintStudentName(std);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//void PrintStudentName(String std)
//{
//    if (std == null)
//        throw new NullReferenceException("Student object is null.");

//    Console.WriteLine(std);
//}