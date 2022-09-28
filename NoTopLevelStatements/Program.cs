using System;

namespace NoTopLevelStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }


        }
    }
}