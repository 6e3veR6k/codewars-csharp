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
    }

    public delegate void MessageDelegate(int expression);
}
