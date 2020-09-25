using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            MyCollection<MyClass> someColl = new MyCollection<MyClass>();

            for (int i = 0; i < 100; i++)
            {
                someColl.Add(new MyClass() { Id = random.Next(0, 999) });
            }


            foreach (var el in someColl)
            {
                Console.WriteLine($"el.Id = {el.Id}");
            }
            Console.WriteLine(new string('#', 20));
            Console.WriteLine(new string('#', 20));
            foreach (var el in someColl)
            {
                Console.WriteLine($"el.Id = {el.Id}");
            }
            Console.WriteLine(new string('#', 20));
            Console.ReadLine();
        }
    }

    public class MyClass
    {
        public int Id { get; set; }
    }

    public class MyCollection<T> : ICollection<T>
    {
        private T[] collection;
        


        public MyCollection()
        {
            this.collection = new T[100];
        }

        public int Count => ((ICollection<T>)collection).Count;

        public bool IsReadOnly => ((ICollection<T>)collection).IsReadOnly;

        public void Add(T item)
        {
            ((ICollection<T>)collection).Add(item);
        }

        public void Clear()
        {
            ((ICollection<T>)collection).Clear();
        }

        public bool Contains(T item)
        {
            return ((ICollection<T>)collection).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)collection).CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((ICollection<T>)collection).GetEnumerator();
        }

        public bool Remove(T item)
        {
            return ((ICollection<T>)collection).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<T>)collection).GetEnumerator();
        }
    }
}
