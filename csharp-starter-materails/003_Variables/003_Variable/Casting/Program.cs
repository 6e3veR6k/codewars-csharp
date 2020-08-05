﻿using System;

// Преобразование типа (Casting или Type conversion) - это преобразование значения переменной одного типа в значение другого типа.
// Выделяют явное (explicit) и неявное (implicit) преобразование типов.

namespace Casting
{
    class Program
    {
        static void Main()
        {
            //   ----------------------------------  Переменные  ---------------------------------------------

            #region Неявное (безопасное) преобразование типа:
            
            // Неявное преобразование значения типа - byte в тип int. (преобразование меньшего типа в больший) 
            byte a = 10;     //                                      0000 1010  -  1 байт
            int b = 0;       //  0000 0000   0000 0000   0000 0000   0000 0000  -  4 байта
            b = a;           //  0000 0000   0000 0000   0000 0000   0000 1010  -  4 байта              

            Console.WriteLine(b);

            // Неявное преобразование значения типа - int в тип float. (преобразование целого типа в вещественный) 
            int c = 255;
            float d = 0f;
            d = c;

            Console.WriteLine(d);
            
            #endregion
            
            #region Явное (опасное) преобразование типа:

            // Явное преобразование значения типа - int в тип byte. 
            // (преобразование большего типа в меньший, приводит к потере части результата)            

            int e = 256;     //  0000 0000   0000 0000   0000 0001   0000 0000  -  4 байта
            byte f = 0;      //                                      0000 0000  -  1 байт
            f = (byte)e;     //                                      0000 0000  -  1 байт
            // f = e;        //  ОШИБКА.

            Console.WriteLine(f);

            // Явное преобразование значения типа - float в тип int.  
            // (преобразование вещественного типа в целый, приводит к потере точности результата)

            float g = 10.5F;
            int h = 0;
            h = (int)g;
            // h = g;         // ОШИБКА.

            Console.WriteLine(h);
            
            #endregion

            //   ----------------------------------  Константы  ----------------------------------------------

            #region Кастинг констант

            // Возможно неявное преобразование значения константы типа - int в тип byte,
            // при инициализации переменной значением константы,
            // если значение константы не превышает максимально допустимого значения переменной.

            const int i = 255;  //  0000 0000   0000 0000   0000 0000   1111 1111  -  4 байта
            byte j = 0;         //                                      0000 0000  -  1 байт
            j = i;              //                                      1111 1111  -  1 байт

            Console.WriteLine(j);

            // Возможно явное преобразование значения константы типа - float в тип byte, 
            // при инициализации переменной значением константы,
            // если значение константы не превышает максимально допустимого значения переменной.

            const float k = 255;
            byte l = 0;
            l = (byte)k;

            Console.WriteLine(l);


            // Невозможно ни явное, ни неявное преобразование значения константы,
            // при инициализации переменной значением константы,
            // если значение константы превышает максимально допустимый диапазон значения переменной.

            const int m = 256;  //  0000 0000   0000 0000   0000 0001   0000 0000  -  4 байта
            byte n = 0;         //                                      0000 0000  -  1 байт
            // n = m;           //  ОШИБКА.
            // n = (byte)m;     //  ОШИБКА.

            Console.WriteLine(n);

            // Невозможно ни явное, ни неявное преобразование значения вещественной константы,
            // при инициализации целочисленной переменной значением константы,
            // если значение константы превышает максимально допустимый диапазон значения переменной.

            const float o = 256.5f; 
            byte p = 0;
            // p = o;           //  ОШИБКА.
            // p = (byte)o;     //  ОШИБКА.

            Console.WriteLine(p);
            
            #endregion
            
            // Задержка.
            Console.ReadKey();
        }
    }
}
