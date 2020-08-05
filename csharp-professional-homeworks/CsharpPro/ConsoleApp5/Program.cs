using System;
using System.Collections;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var els = new[] { 1, 2, 3, 4, 5, 6, 8 };

            foreach(var el in GetArrayOfPowers(els))
            {
                Console.WriteLine(el);
            }
        }

        /*
         * Создайте метод, который в качестве аргумента принимает массив целых чисел и возвращает
         * коллекцию квадратов всех нечетных чисел массива. Для формирования коллекции
         * используйте оператор yield.
         */

        public static IEnumerable GetArrayOfPowers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    yield return array[i] * array[i];
                }
            }
        }
    }


    /*
     * Создайте коллекцию, в которой бы хранились наименования 12 месяцев, порядковый номер и
     * количество дней в соответствующем месяце. Реализуйте возможность выбора месяцев, как по
     * порядковому номеру, так и количеству дней в месяце, при этом результатом может быть не
     * только один месяц.
     */
}
