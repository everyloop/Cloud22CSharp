//int i = 1;

//while (i < 10)
//{
//    Console.WriteLine(i);
//    i++;
//}

//do
//{
//    Console.WriteLine("hej");
//} while (false);


//for (int j = 1; j < 10; j++)
//{
//    Console.WriteLine(j);
//}

for (int i = 1; i <= 3; i++)
{
    Print1to9fourTimes();
}

void Print1to9fourTimes()
{
    for (int j = 1; j <= 4; j++)
    {
        Print1to9();
    }
    Console.WriteLine("----------");
}

void Print1to9()
{
    for (int k = 1; k < 10; k++)
    {
        Console.Write(k);
    }
    Console.WriteLine();
}



