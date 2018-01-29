using System;
using System.Collections.Generic;

namespace Lesson8._2
{
    class Program
    {
        // Программа находит меньшее число из 3-х, с помощью метода "MinimumNumber"

        public static int MinimumNumber(List<int> numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }
            return min;
        }

        static void Main(string[] args)
        {
            int number1, number2, number3, min;

            List<int> number = new List<int>();

            Console.Write("Enter the number 1:");
            number1 = Convert.ToInt32(Console.ReadLine());
            number.Add(number1);

            Console.Write("Enter the number 2:");
            number2 = Convert.ToInt32(Console.ReadLine());
            number.Add(number2);

            Console.Write("Enter the number 3:");
            number3 = Convert.ToInt32(Console.ReadLine());
            number.Add(number3);

            min = MinimumNumber(number);
            Console.WriteLine("The minimum number of entered:" + min);

            Console.ReadKey();
        }
    }
}
