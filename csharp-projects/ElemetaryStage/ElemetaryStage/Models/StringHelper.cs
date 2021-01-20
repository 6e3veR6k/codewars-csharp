using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElemetaryStage.Models
{
    public delegate int CountDelegate(string message);

    public class StringHelper
    {
        public int GetCount(string inputString)
        {
            return inputString.Length;
        }


        public int GetCountSymbolA(string inputString)
        {
            return inputString.Count(c => c == 'A');
        }


        public int GetCountSymbol(string inputString, char symbol)
        {
            return inputString.Count(c => c == symbol);
        }
    }
}
