using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Starter
{
    public class Variable
    {
        private int x;
        private int y;
        private int z;

        public Variable()
        {
            x = 10;
            y = 12;
            z = 3;
        }

        public void ShowResult(MessageDelegate messageDelegate)
        {
            messageDelegate(x += y - x++ * z);
            messageDelegate(z = --x - y * 5);
            messageDelegate(y /= x + 5 % z);
            messageDelegate(z = x++ + y * 5);
            messageDelegate(x = y - x++ * z);
        }


        /// <summary>
        /// mockup function for configuration unit tests
        /// </summary>
        /// <param name="a">first argument</param>
        /// <param name="b">second argument</param>
        /// <returns>Summ of arguments</returns>
        public double GetSumm(double a, double b) => a + b;
    }

    public delegate void MessageDelegate(int expression);
}
