// See https://aka.ms/new-console-template for more information

using System.Globalization;

string name = "Fredrik dricker cola, och tycker det är gott";

// Replace, Remove
Console.WriteLine("Replace('r', 'X'): " + name.Replace('r', 'X'));
Console.WriteLine("Replace(\"dri\", \"X\"): " + name.Replace("dri", "X"));
Console.WriteLine("Remove(5,2): " + name.Remove(5,2));
Console.WriteLine("Substring(5,2): " + name.Substring(5,2)); 
Console.WriteLine("Insert(16, \"inte \"): " + name.Insert(16, "inte ")); 
Console.WriteLine();

// Upper / Lower
Console.WriteLine("ToLower(): " + name.ToLower());
Console.WriteLine("ToUpper(): " + name.ToUpper());
Console.WriteLine();

// Split
Console.WriteLine("Split string on spaces:");
string[] words = name.Split(' ');

foreach (string word in words)
{
    Console.WriteLine($"{word.Trim().PadRight(10)}: {word.Trim().Length.ToString().PadLeft(2)}");
}
Console.WriteLine();

// Trim
Console.WriteLine("Trim alternatives:");
Console.WriteLine("     hej    ".TrimStart() + "<<" );
Console.WriteLine("     hej    ".TrimEnd() + "<<");
Console.WriteLine("     hej    ".Trim() + "<<");
Console.WriteLine();

// IndexOf
Console.WriteLine("IndexOf(\"dri\"): " + name.IndexOf("dri"));
Console.WriteLine("LastIndexOf(\"dri\"): " + name.LastIndexOf("dri"));
Console.WriteLine();

// PadLeft / PadRight
Console.WriteLine("PadLeft / PadRight");
Console.WriteLine("Hej".PadLeft(10));
Console.WriteLine("Hej".PadRight(10));
Console.WriteLine();

// String.Empty == ""
string myString = String.Empty;
string s = "    ";

if (String.IsNullOrEmpty(s)) {}
if (String.IsNullOrWhiteSpace(s)) { }
if (s == null || s.Trim() == String.Empty) { }

// Concat, Join
string[] cities = { "Stockholm", "Göteborg", "Malmö", "Borås" };

Console.WriteLine("Concat / Join");
Console.WriteLine(String.Concat(cities));
Console.WriteLine(String.Join(" - ", cities));
