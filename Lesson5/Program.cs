using System;
using System.Collections.Generic;
namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Одномерный массив
            int x;

            /*  Console.Write("Введите число массива:");
              x = Convert.ToInt32(Console.ReadLine());

              int[] massive = new int[3];
              massive[0] = x;
              massive[1] = 5 + x;
              massive[2] = 10 + x;

              for (int i = 0; i < massive.Length; i++)

                  Console.WriteLine(massive[i]);
              */

            // Строковый массив

            /* string[] text = new string[3] {
                 "Sergei", "Ivan", "Petr"
              };

             for (int i = 0; i < text.Length; i++)

                 Console.WriteLine(text[i]);
              */

            // Массив, список

            List<int> nunbers = new List<int>();
            nunbers.Add(15);
            nunbers.Add(23);

            Console.WriteLine(nunbers[1]);

            Console.ReadKey();









        }
    }
}
