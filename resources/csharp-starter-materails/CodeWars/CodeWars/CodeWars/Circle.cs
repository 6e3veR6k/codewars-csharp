using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class Circle
    {
        //Создайте класс Circle.В классе создайте не публичное поле вещественного типа – radius.
        //Создайте методы доступа(свойства) к этому полю – аксессор и мутатор.Создайте два
        //метода в теле класса – GetArea() и GetCircumference(), возвращающие соответственно площадь круга и длину окружности.
        //В методе Main создайте экземпляр класса Circle.
        // Пользователь должен ввести радиус круга.Вызовите соответствующие методы и выведите на экран площадь этого круга и длину окружности.

        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }


        public double GetArea() => Math.PI * Math.Pow(Radius, 2);

        public double GetCircumference() => 2 * Math.PI * Radius;


    }
}
