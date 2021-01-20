using System;
using System.Collections.Generic;
using System.Text;

namespace ElemetaryStage.Models
{
    public class Instance
    {
        private Instance instance = null;

        private int Count;

        public Instance()
        {
            instance = new Instance();
            instance.Initialize();
        }

        private void Initialize()
        {
            Count = 10;
            Console.WriteLine("Ok!");
        }
    }
}
