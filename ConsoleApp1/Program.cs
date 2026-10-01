// See https://aka.ms/new-console-template for more information
// FOOBAR EXERCISE

int maxNum = 50;

var numbers = Enumerable.Range(1, maxNum);

// foreach (int num in numbers)
// {

//     if (num % 3 == 0 && num % 5 == 0)
//     {
//         Console.Write(" foobar ");
//         continue;
//     }

//     if (num % 3 == 0)
//     {
//         Console.Write(" foo, ");
//         continue;
//     }

//     if (num % 5 == 0)
//     {
//         Console.Write(" bar, ");
//         continue;
//     }

//     Console.Write(num + ", ");
// }


// QUEUE EXERCISE
List<int> queue = [];
void Enqueue(int number)
{
    Console.WriteLine($"Queued {number}");
    queue.Add(number);
}

void Process()
{
    if (queue.Count == 0)
    {
        Console.WriteLine("Queue is empty");
        return;
    }

    Console.WriteLine($"Processed {queue[0]}");
    queue.RemoveAt(0);

}

Enqueue(4);
Enqueue(5);
Enqueue(9);
Enqueue(3);
Process();
Process();
Process();
Process();
Enqueue(7);
Enqueue(99);
Enqueue(89);
Process();
Process();
Process();
Process();