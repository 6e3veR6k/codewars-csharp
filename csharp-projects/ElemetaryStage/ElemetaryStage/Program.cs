using ElemetaryStage.Models;
using System;
using System.Globalization;

#region
/*
 * Требуется: Создать класс с именем Rectangle.
 * В теле класса создать два поля, описывающие длины сторон  double side1, side2.
 * Создать пользовательский конструктор  Rectangle(double side1, double side2) , в теле которого
 * поля  side1 и side2 инициализируются значениями аргументов.
 * Создать два метода, вычисляющие площадь прямоугольника -  double AreaCalculator() и периметр
 * прямоугольника -  double PerimeterCalculator().
 * Создать два свойства  double Area и double Perimeter с одним методом доступа get.
 * Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
 * на экран периметр и площадь.
 */
#endregion

namespace ElemetaryStage
{


    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter first side of the rectangle");
            var firstSide = GetRectangleSide();

            Console.WriteLine("Enter second side of the rectangle");
            var secondSide = GetRectangleSide();

            Rectangle rectangle = new Rectangle(firstSide, secondSide);

            Console.WriteLine($"Rectangle with sides: {firstSide}X{secondSide} has area = {rectangle.Area} and perimeter = {rectangle.Perimeter};");

            Console.ReadLine();
        }

        private static double GetRectangleSide()
        {
            double side;

            while (true)
            {
                side = GetUserInputValue();

                if (side <= 0)
                {
                    Console.WriteLine($"Side cann't be negative or zero: {side}");
                    continue;
                }

                break;
            }

            return side;
        }


        private static double GetUserInputValue()
        {
            double userValue;
            while (true)
            {
                var userInput = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Input cannot be empty, try again.");
                    continue;
                }

                if (!double.TryParse(userInput, NumberStyles.Float | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out userValue))
                {
                    Console.WriteLine("Input cannot be parsed, try again.");
                    continue;
                }

                break;
            }

            return userValue;
        }
    }

}
