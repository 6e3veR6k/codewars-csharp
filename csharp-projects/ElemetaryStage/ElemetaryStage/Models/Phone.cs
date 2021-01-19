using ElemetaryStage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElemetaryStage.Models
{
    public class Phone : IPhone
    {
        public string FullNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private int arp = 10;

        public int Age { get; private set; }
        public int Arp { get; }


        public void SetArp()
        { 
            this.arp = 10; 
            this.Age = 12; 
        }
    }
}
