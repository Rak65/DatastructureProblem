using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class LinkedListCRUD<T>
    {
        private LinkedList<T> linkedList;

        public LinkedListCRUD()
        {
            linkedList = new LinkedList<T>();
        }

        public void Add(T item)
        {
            linkedList.AddLast(item);
        }

        public void Display()
        {
            foreach (var item in linkedList)
            {
                Console.Write($"{item} -> ");
            }
            Console.WriteLine("null");
        }

        public void Remove(T item)
        {
            linkedList.Remove(item);
        }

        public bool Contains(T item)
        {
            return linkedList.Contains(item);
        }
    }
}
