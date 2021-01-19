using System;

namespace ElemetaryStage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Sum(int a, int b) => a + b;

        public static double GetPerimeter(double firstSide, double secondSide) => 2 * (firstSide + secondSide);
    }
}
