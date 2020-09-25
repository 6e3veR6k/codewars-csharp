using System;
using System.Collections.Generic;
using System.Xml;

namespace ConsoleApp999
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person { Id = 1, FirstName = "Nikolay", SecondName = "Antonov", LastName = "Petrov", BirthDate = DateTime.Parse("1986-09-04") };
            Person b = new Person { Id = 2, FirstName = "Grigoriy", SecondName = "Alexandrovich", LastName = "Kozlov", BirthDate = DateTime.Parse("1986-09-05") };
            Person c = new Person { Id = 3, FirstName = "Semen", SecondName = "Sergeev", LastName = "Nikiforov", BirthDate = DateTime.Parse("1986-09-06") };
             

            List<Person> persons = new List<Person> { a, b, c };


            XmlDocument doc = new XmlDocument();


            doc.Load("file.xml");

            XmlElement root = doc.DocumentElement;

            foreach (XmlNode node in root)
            {
                if (node.Attributes.Count > 0)
                {
                    var t = node.Attributes;
                    foreach(XmlAttribute d in t)
                    {
                        Console.WriteLine($"{d.Name} - {d.Value}");
                    }
                }
            }

        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
