using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ElemetaryStage.Models
{
    public delegate void ShowMessage(string message);


    public class Student
    {
        public void Move(int distance, ShowMessage method)
        {
            for(int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                method(string.Format("Rolling... Distance: {0}", i));
            }
        }


        public int GetAge()
        {
            return 17;
        }

        
        public string Grow(int years)
        {
            return null;
        }


        public void SetInfo(string name, int age)
        {
            
        }


        public void SetSchool(int id, string number)
        {

        }
    }
}
