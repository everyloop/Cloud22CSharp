// See https://aka.ms/new-console-template for more information
string name = "Fredrik";
Console.WriteLine(name.ToTitle());
Console.WriteLine("HEJSAN".ToTitle());

public static class StringExtensions
{
    public static string ToTitle(this string text)
    {
        string returnValue = text[0].ToString().ToUpper();
        returnValue += text.Substring(1).ToLower();
        return returnValue;
    }
}