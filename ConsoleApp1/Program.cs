// See https://aka.ms/new-console-template for more information
// FOOBAR EXERCISE

using ConsoleApp1;

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
// List<int> queue = [];
// void Enqueue(int number)
// {
//     Console.WriteLine($"Queued {number}");
//     queue.Add(number);
// }

// void Process()
// {
//     if (queue.Count == 0)
//     {
//         Console.WriteLine("Queue is empty");
//         return;
//     }

//     Console.WriteLine($"Processed {queue[0]}");
//     queue.RemoveAt(0);

// }

// Enqueue(4);



// List<string> myStack = [];

// void Type(string text)
// {
//     Console.WriteLine($"Typed [{text}] ");
//     myStack.Add(text);
// }

// void Undo()
// {

//     if (myStack.Count != 0)
//     {

//         var text = myStack[myStack.Count - 1];
//         myStack.RemoveAt(myStack.Count - 1);
//         Console.WriteLine($"Undid [{text}] ");
//         return;
//     }

//     Console.WriteLine("Stack Empty ");
// }


// Type("foo");
// Type("bar");
// Type("sala");
// Type("tiga");

// Undo();
// Undo();
// Undo();


List<CustomNode> myListCsNode = [];
void Append(int num)
{
    if (myListCsNode.Count == 0)
    {
        
        myListCsNode.Add(new CustomNode(num));
        Console.WriteLine($"Appended {num}");
        return;
    }

    CustomNode csNode = new CustomNode(num);
    myListCsNode[myListCsNode.Count-1].next = csNode;
    myListCsNode.Add(csNode);
    Console.WriteLine($"Appended {num}");
}


void Print()
{
    foreach (var item in myListCsNode)
    {
        if (item.next is not null)
        {
            Console.Write($"{item.val} -> ");
            continue;
        }
        Console.Write($"{item.val}");

    }
}

Append(5);
Append(50);
Append(10);
Append(3);
Append(6);
Append(9);
Print();