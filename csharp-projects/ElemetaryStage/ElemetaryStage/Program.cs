using ElemetaryStage.Models;
using System;

namespace ElemetaryStage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            StringHelper helper = new StringHelper();

            CountDelegate delegate1 = helper.GetCount;
            CountDelegate delegate2 = helper.GetCountSymbolA;

            string testingString = "LAMP";

            Console.WriteLine(TestDelegate(delegate1, testingString));
            Console.WriteLine(TestDelegate(delegate2, testingString));

            Console.ReadLine();
        }

        public static int Sum(int a, int b) => a + b;

        public static double GetPerimeter(double firstSide, double secondSide) => 2 * (firstSide + secondSide);

        public static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }
    }
}
