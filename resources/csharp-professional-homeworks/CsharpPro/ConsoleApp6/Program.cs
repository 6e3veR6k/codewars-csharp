using System;

/*
 * Создайте библиотеку, в которой: 
 * Создайте перечисление LevelOfResponsibility с такими уровнями – Undetermined, Highest, Average, Low.
 * 
 * Создайте класс-атрибут OfficerAttribut, работающий только с классами.
 * В теле OfficerAttribut создайте автосвойство Responsibility типа LevelOfResponsibility.
 * 
 * Создайте абстрактный класс Officer. Создайте конкретные классы General, Major, Lieutenant, наследующиеся от Officer.
 * Декорируйте все созданные классы соответствующими атрибутами. 
 * В другом проекте в методе Main создайте экземпляры всех классов, наследников Officer. Выведите на экран их атрибуты.
 */


namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
