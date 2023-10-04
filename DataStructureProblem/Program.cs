using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Which program you want to run");
                Console.WriteLine("1. Custom Linked List.");
                Console.WriteLine("2. Custom Stack");
                Console.WriteLine("3. Custom Queues.");
                Console.WriteLine("4. Linked List CRUD");
                Console.WriteLine("5. Stack CRUD");
                Console.WriteLine("6. Queue CRUD");
                Console.WriteLine("7. Sorted Linked List in descending order.");
                Console.WriteLine("8.Exit");
                string choice=Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CustomLinkedList<int> intList = new CustomLinkedList<int>();
                        intList.Add(1);
                        intList.Add(2);
                        intList.Add(3);
                        intList.Print();

                        CustomLinkedList<string> stringList = new CustomLinkedList<string>();
                        stringList.Add("A");
                        stringList.Add("B");
                        stringList.Add("C");
                        stringList.Print();
                        break;
                    case "2":
                        CustomStack<int> intStack = new CustomStack<int>();
                        intStack.Push(10);
                        intStack.Push(20);
                        intStack.Push(30);

                        Console.WriteLine("Stack elements:");
                        while (intStack.Count > 0)
                        {
                            Console.WriteLine(intStack.Pop());
                        }

                        CustomStack<string> stringStack = new CustomStack<string>();
                        stringStack.Push("A");
                        stringStack.Push("B");
                        stringStack.Push("C");

                        Console.WriteLine("Stack elements:");
                        while (stringStack.Count > 0)
                        {
                            Console.WriteLine(stringStack.Pop());
                        }
                        break;
                    case "3":
                        CustomQueue<int> intQueue = new CustomQueue<int>();
                        intQueue.Enqueue(10);
                        intQueue.Enqueue(20);
                        intQueue.Enqueue(30);

                        Console.WriteLine("Queue elements:");
                        while (intQueue.Count > 0)
                        {
                            Console.WriteLine(intQueue.Dequeue());
                        }

                        CustomQueue<string> stringQueue = new CustomQueue<string>();
                        stringQueue.Enqueue("A");
                        stringQueue.Enqueue("B");
                        stringQueue.Enqueue("C");

                        Console.WriteLine("Queue elements:");
                        while (stringQueue.Count > 0)
                        {
                            Console.WriteLine(stringQueue.Dequeue());
                        }
                        break;
                    case "4":
                        LinkedListCRUD<int> intLinkedList = new LinkedListCRUD<int>();
                        intLinkedList.Add(10);
                        intLinkedList.Add(20);
                        intLinkedList.Add(30);

                        Console.WriteLine("Linked List elements:");
                        intLinkedList.Display();

                        intLinkedList.Remove(20);
                        Console.WriteLine("After removing 20:");
                        intLinkedList.Display();

                        Console.WriteLine("Does the linked list contain 10? " + intLinkedList.Contains(10));
                        Console.WriteLine("Does the linked list contain 40? " + intLinkedList.Contains(40));
                        break;
                    case "5":
                        // Create a stack and add items
                        Stack<int> inStack = new Stack<int>();
                        inStack.Push(10);
                        inStack.Push(20);
                        inStack.Push(30);

                        // Read (Peek) the top item
                        Console.WriteLine("Top item: " + inStack.Peek());

                        // Display the stack elements
                        Console.WriteLine("Stack elements:");
                        foreach (var item in inStack)
                        {
                            Console.WriteLine(item);
                        }

                        // Pop (Delete) the top item
                        int poppedItem = inStack.Pop();
                        Console.WriteLine("Popped item: " + poppedItem);

                        // Check if an item exists
                        Console.WriteLine("Does the stack contain 20? " + inStack.Contains(20));
                        Console.WriteLine("Does the stack contain 40? " + inStack.Contains(40));
                        break;
                    case "6":
                        // Create a queue and add items
                        Queue<int> inQueue = new Queue<int>();
                        inQueue.Enqueue(10);
                        inQueue.Enqueue(20);
                        inQueue.Enqueue(30);

                        // Read (Peek) the front item
                        Console.WriteLine("Front item: " + inQueue.Peek());

                        // Display the queue elements
                        Console.WriteLine("Queue elements:");
                        foreach (var item in inQueue)
                        {
                            Console.WriteLine(item);
                        }

                        // Dequeue (Delete) the front item
                        int dequeuedItem = inQueue.Dequeue();
                        Console.WriteLine("Dequeued item: " + dequeuedItem);

                        // Check if an item exists
                        Console.WriteLine("Does the queue contain 20? " + inQueue.Contains(20));
                        Console.WriteLine("Does the queue contain 40? " + inQueue.Contains(40));
                        break;
                    case "7":
                        SortedLinkedList sortedList = new SortedLinkedList();
                        sortedList.Insert(40);
                        sortedList.Insert(30);
                        sortedList.Insert(50);
                        sortedList.Insert(20);

                        Console.WriteLine("Sorted Linked List elements:");
                        sortedList.Display();
                        break;
                    case "8":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Try again:---");
                        break;
                }
            }
        }
    }
}
