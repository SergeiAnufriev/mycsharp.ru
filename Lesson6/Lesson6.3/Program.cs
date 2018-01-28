using System;

namespace Lesson6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Программа для сложения двух массивов 

            int summ = 0;
            int[] numbers1 = { 5, 6, 8, 9, 31, 12, 52, 32, 22, 15 };
            int[] numbers2 = { 3, 5, 9, 12, 16, 1, 32, 15, 14, 9 };

            Console.Write("Numbers1:");

            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.Write(numbers1[i] + ",");
            }

            Console.WriteLine();
            Console.Write("Numbers2:");

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.Write(numbers2[i] + ",");
            }

            Console.WriteLine();
            Console.Write("Summ:");

            for (int i = 0; i < numbers1.Length; i++)
            {
                summ = numbers1[i] + numbers2[i];
                Console.Write(summ + ",");
            }


            Console.ReadKey();
        }
    }
}
