// case sensitive    - gör skillnad på små och stora bokstäver
// case insensitive  - gör inte skillnad på små och stora bokstäver

// Uppercase: MYVARIABLE
// Lowercase: myvariable
// Pascalcase: MyVariable
// Camelcase: myVariableThatIsAwesome,  firstName
// Snakecase: my_variable

// Unsigned
byte myByte = 8;           // Range 0 -> 2^8 = 256
ushort myUshort = 16;      // Range 0 -> 2^16 = 65536
uint myUint = 32;         // Range 0 -> 2^32 = 4 294 967 296
ulong myUlong = 64;        // Range 0 -> 2^64 = 18 446 744 073 709 551 616

// Signed
SByte mySByte = 8;       // Range -128 till +128
sbyte mySbyte = 8;

Int16 myInt16 = 16;      // Range minus 32768 till plus 32767 
short myShort = 16;

Int32 myInt32 = 32;      // Range minus ~2.1 miljarder till plus ~2.1 miljarder
int myInt = 32;

Int64 myInt64 = 64;      // Range 18 446 744 073 709 551 616
long myLong = 64;

// Datatyper som lagar siffror som inte är heltal

Single mySingle = 3.14f;
float myFloat = 3.14f;          // 32 bitar

Double myDoubleNet = 3.14;
double myDouble = 3.14;         // 64 bitar

Decimal myDecimalNet = 3.14M;
decimal myDecimal = 3.14M;      // 128 bitar

// Implict typad variabel (med keyword var)
var implicitVar = 5.0f;

// Suffix
// f för float (ex: 0.5f)
// M för decimal (ex: 0.5M)
// L för long (ex: 5L)

String myStringDotNet = "";
string myString = "använd för att lagra text";

Char myCharDotNet = 'A';
char myChar = '5';

Boolean myBoolDotNet = false;
bool myBool = true;

// Variabler

var x = 5.0;

x = 5;

var y = x + 2;

Console.WriteLine("x = " + x + ", y = " + y);
Console.WriteLine("x = {0}, y = {1}", x, y);
Console.WriteLine($"x = {x}, y = {y}");


string firstName = "Fredrik";
double radius = 5.3;


// Block Scope: Variabler är endast giltiga i det kodblock de deklarerats i.

myFunction();

if (firstName == "Fredrik")
{
    string lastName = "Johansson";

    if (lastName == "Johansson")
    {
        int age = 41;
        Console.WriteLine($"{firstName} {lastName}");
    }
}

myFunction();
myFunction();


// Method/Function Scope: Varibler är endast giltiga i funktionen/metoden de deklareras i.
void myFunction()
{
    string text = "hejsan";
    Console.WriteLine(text);
}

// Console.WriteLine(text); Variablen "text" går inte att använda utanför funktionen

int inputValue;

inputValue = Int32.Parse(Console.ReadLine());

//int number = Convert.ToInt32(inputValue);
//int number = Int32.Parse(inputValue);

Console.WriteLine(inputValue + 2);


