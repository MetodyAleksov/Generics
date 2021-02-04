using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        public Box()
        {
            Elements = new List<T>();
        }
        public Box(List<T> arr)
            :this()
        {
            Elements = arr;
        }
        public List<T> Elements { get; set; }
        public int Count => this.Elements.Count;

        public void Add(T element)
        {
            Elements.Add(element);
        }
        
        public T Remove()
        {
            T el = Elements[Elements.Count - 1];
            Elements.RemoveAt(Elements.Count - 1);
            return el;
        }
    }
}
