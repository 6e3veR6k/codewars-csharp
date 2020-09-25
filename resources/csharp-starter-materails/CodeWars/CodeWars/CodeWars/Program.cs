using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            double userRadius = GetUserNumber();
            Circle circle = new Circle();
            circle.Radius = userRadius;

            double userCircleArea = circle.GetArea();
            double userCircleCircumference = circle.GetCircumference();

            Console.WriteLine($"Radius = {circle.Radius}, Area = {userCircleArea}, Circumference = {userCircleCircumference}");

            Console.WriteLine(new string('#', 50));


            Library library = new Library();
            Library library2 = new Library("War and Peace", "Tolstoy");

            Console.WriteLine(library);
            Console.WriteLine(library2);

        }

        static double GetUserNumber()
        {
            double result = default(double);

            bool isParsed = default(bool);

            while(!isParsed)
            {
                Console.Write("Enter radius: ");
                string userString = Console.ReadLine();
                isParsed = double.TryParse(userString,out result);
            }

            return result;
        }
    }
}
