// See https://aka.ms/new-console-template for more information
// FOOBAR EXERCISE

using ConsoleApp1;

int maxNum = 50;

var numbers = Enumerable.Range(1, maxNum);

foreach (int num in numbers)
{

    if (num % 3 == 0 && num % 5 == 0)
    {
        Console.Write(" foobar ");
        continue;
    }

    if (num % 3 == 0)
    {
        Console.Write(" foo, ");
        continue;
    }

    if (num % 5 == 0)
    {
        Console.Write(" bar, ");
        continue;
    }

    Console.Write(num + ", ");
}

