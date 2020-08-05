using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp3
{e
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

    public class MyCollection<T> : IList<T>
    {
        private T[] collection;



        public MyCollection()
        {
            this.collection = new T[100];
        }

        public T this[int index] { get => ((IList<T>)collection)[index]; set => ((IList<T>)collection)[index] = value; }

        public int Count => ((IList<T>)collection).Count;

        public bool IsReadOnly => ((IList<T>)collection).IsReadOnly;

        public void Add(T item)
        {
            ((IList<T>)collection).Add(item);
        }

        public void Clear()
        {
            ((IList<T>)collection).Clear();
        }

        public bool Contains(T item)
        {
            return ((IList<T>)collection).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((IList<T>)collection).CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IList<T>)collection).GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return ((IList<T>)collection).IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            ((IList<T>)collection).Insert(index, item);
        }

        public bool Remove(T item)
        {
            return ((IList<T>)collection).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<T>)collection).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<T>)collection).GetEnumerator();
        }
    }
}
