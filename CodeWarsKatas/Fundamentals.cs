using System;
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
    }
}
