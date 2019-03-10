using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Myqueue<T> : IEnumerable<T>
    {
        private List<T> items;

        public Myqueue()
        {
            items = new List<T>();
        }
        public void Enqueue(T item)
        {
            items.Insert(0, item);
        }

        public T Dequeue()
        {
            T item = items[0];
            items.RemoveAt(0);
            return item;
        }

        public void Clear()
        {
            items.Clear();
        }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
        }

        public override string ToString()
        {
            string result = null;
            foreach(var item in items)
            {
                result += item;
            }
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
