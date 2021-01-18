using Base.Starter;
using System;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonachi(15);
        }

        static void Fibonachi(int i)
        {
            int previous = 0;
            int current = 1;

            for(; i > 0; i--)
            {

                Console.Write(current + "\t");
                int temp = current;
                current = previous + current;
                previous = temp;
            }
        }

    }
}
