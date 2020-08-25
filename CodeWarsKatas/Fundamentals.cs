using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsKatas
{
    public class Fundamentals
    {
        public static string SayHello(string name)
        {
            return "Hello" + ", " + name;
        }


        public static int AreaOrPerimeter(int l, int w)
        {
            return (w == l) ? (w * l) : 2 * (w + l);
        }


        public static double? ParseF(object s = null)
        {
            double? result = null;

            if (Double.TryParse(s as string, out double parsed))
            {
                result = parsed;
            }

            return result;
        }


        public static string RepeatStr(int n, string s)
        {
            var t = new StringBuilder();
            while (n > 0)
            {
                t.Append(s);
                n--;
            }

            return t.ToString();

            //1.
            //return String.Concat(Enumerable.Repeat(s, n));
            //2.
            //return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
        }


        public static string Solution(string a, string b)
        {
            return a.Length >= b.Length ? $"{b}{a}{b}" : $"{a}{b}{a}";
        }


        public static bool isDivisible(long n, long x, long y)
        {
            return n % x == 0 && n % y == 0;
        }


        public static List<int> FindMultiples(int integer, int limit)
        {
            List<int> result = new List<int>();
            int multiple = 1;
            while(multiple * integer <= limit)
            {
                result.Add(multiple * integer);
                multiple++;
            }

            return result;
        }

        public static void SetValue(string value)
        {
            Console.Read();
        }


    }
}
