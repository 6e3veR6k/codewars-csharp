using System;
using System.Collections.Generic;

namespace ConsoleApp2
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


            foreach (var el in someColl.GetValues())
            {
                Console.WriteLine($"el.Id = {el.Id}");
            }
            Console.WriteLine(new string('#', 20));
            Console.WriteLine(new string('#', 20));
            foreach (var el in someColl.GetValues())
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


    public class MyCollection<T>
    {
        private T[] collection;
        private static readonly T[] emptyArray = new T[0];
        private int position = -1;
        private int count;
        private int defaultCapacity = 4;

        public int Count
        {
            get => count;
        }

        public IEnumerable<T> GetValues()
        {
            while (position < count - 1)
            {
                position++;
                yield return collection[position];
            }
            
            position = -1;
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }

                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }

        public void Add(T element)
        {
            if (count == collection.Length)
            {
                defaultCapacity *= 4;
                T[] newArray = new T[defaultCapacity];
                if (count != 0)
                {
                    Array.Copy(collection, 0, newArray, 0, collection.Length);
                }
                collection = newArray;
            }

            collection[count++] = element;
        }


        public MyCollection()
        {
            this.collection = emptyArray;
        }


    }
}
