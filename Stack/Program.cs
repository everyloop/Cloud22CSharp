// See https://aka.ms/new-console-template for more information

Stack<string> names = new Stack<string>();

string userInput = String.Empty;
do
{
    userInput = Console.ReadLine();
    names.Push(userInput);

} while (userInput != String.Empty);

while (names.Count > 0)
{
    Console.WriteLine(names.Pop());
    Thread.Sleep(500);
}


