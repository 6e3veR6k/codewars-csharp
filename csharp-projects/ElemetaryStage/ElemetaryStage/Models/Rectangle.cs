using System;

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

namespace ElemetaryStage.Models
{
    public class Rectangle
    {
        private double firstSide;
        public double FirstSide 
        { 
            get => firstSide;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length of rectangle side cant be less than 0", nameof(FirstSide));
                }
                else
                {
                    firstSide = value;
                }
            }
        }


        private double secondSide;
        public double SecondSide 
        {
            get => secondSide;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length of rectangle side cant be less than 0", nameof(SecondSide));
                }
                else
                {
                    secondSide = value;
                }
            }
        }


        public double Area { get => AreaCalculator(); }
        public double Perimeter { get => PerimeterCalculator(); }



        public Rectangle(double firstSide, double secondSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
        }

        private double AreaCalculator()
        {
            return FirstSide * SecondSide;
        }

        private double PerimeterCalculator()
        {
            return 2 * (FirstSide + SecondSide);
        }

    }
}
