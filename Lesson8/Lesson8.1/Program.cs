using System;

namespace Lesson8._1
{
    class Program
    {
        // Программа изменяет числа на противоположные по знаку, с помощью нового метода "OtherNumbers"

        public static void OtherNumbers(int[] number, int numbers, int NewNumbers)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == numbers)
                {
                    number[i] = NewNumbers;
                }

                Console.Write(number[i] + ",");
            }
        }

        static void Main(string[] args)
        {
            int[] number = { 2, 3, 6, 9, 5, 7, 6, 2, 5, 6 };
            OtherNumbers(number, 6, -6);
            Console.ReadKey();
        }
    }
}
