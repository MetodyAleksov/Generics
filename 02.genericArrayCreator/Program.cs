using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);

        }
    }
    public static class ArrayCreator<T>
    {
        public static T[] Create<T>(int length, T element)
        {
            T[] arr = new T[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = element;
            }
            return arr;
        }
    }
}
