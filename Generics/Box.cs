using System.Collections.Generic;

namespace BoxOfT
{
    public class BoxOfT<T>
    {
        List<T> elements;
        public BoxOfT()
        {
            elements = new List<T>();
        }

        public void Add(T element)
        {
            elements.Add(element);
        }
        public T Remove()
        {
            T removedEl = elements[0];
            elements.RemoveAt(0);
            return removedEl;
        }
    }
}
