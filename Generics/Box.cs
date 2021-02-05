using System.Collections.Generic;
using System;

namespace BoxOfT
{
    public class BoxOfT<T>
    {
        private Stack<T> elements;
        public int Count { get; private set; }
        public BoxOfT()
        {
            elements = new Stack<T>();
        }

        public void Add(T element)
        {
            elements.Push(element);
            Count = elements.Count;
        }
        public T Remove()
        {
            Count--;
            return elements.Pop();
        }
    }
}
