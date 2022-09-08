// See https://aka.ms/new-console-template for more information


MethodA(10);

void MethodA(int number)
{
    Console.WriteLine(number);
    if (number > 0) MethodA(number - 1);
}

void MethodB()
{
    Console.WriteLine("MethodB");
    //MethodA();
}

void MethodC()
{
    Console.WriteLine("MethodC");
}
