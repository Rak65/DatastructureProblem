using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class CustomStack<T>
    {
        private List<T> elements;

        public CustomStack()
        {
            elements = new List<T>();
        }

        public void Push(T item)
        {
            elements.Add(item);
        }

        public T Pop()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            T item = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return elements[elements.Count - 1];
        }

        public int Count
        {
            get { return elements.Count; }
        }
    }
}
