using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class CustomQueue<T>
    {
        private Queue<T> elements;

        public CustomQueue()
        {
            elements = new Queue<T>();
        }

        public void Enqueue(T item)
        {
            elements.Enqueue(item);
        }

        public T Dequeue()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            return elements.Dequeue();
        }

        public T Peek()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            return elements.Peek();
        }

        public int Count
        {
            get { return elements.Count; }
        }
    }
}
