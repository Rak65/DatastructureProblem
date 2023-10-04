using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureProblem
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class SortedLinkedList
    {
        private Node head;

        public SortedLinkedList()
        {
            head = null;
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);

            // If the list is empty or the new node is greater than the head node
            if (head == null || data > head.Data)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node current = head;

                // Traverse the list to find the correct position to insert the new node
                while (current.Next != null && current.Next.Data < data)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void Display()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
