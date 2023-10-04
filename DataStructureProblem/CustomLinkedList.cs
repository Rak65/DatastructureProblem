using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class CustomLinkedList<T>
    {
        private Node<T> head;
        private int count;

        public int Count { get { return count; } }

        public CustomLinkedList()
        {
            head = null;
            count = 0;
        }

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            count++;
        }

        public void Print()
        {
            Node<T> current = head;

            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
