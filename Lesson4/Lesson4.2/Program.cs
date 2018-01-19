using System;

namespace Lesson4._2
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Программа для нахождения чискл кратных 3-м и 7-ми
            int number;
            Console.Write("Enter the number:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0)  //Нахождение остатка при делении числа на 3

                if (number % 7 == 0)  // Нахождение остатка при делении на 7
                {
                    Console.WriteLine("The number is a multiple of 3 and 7");
                }
                else
                {
                    Console.WriteLine("The number is not a multiple of 3 and 7");
                }
            else Console.WriteLine("The number is not a multiple of 3 and 7");

            Console.ReadKey();




        }
    }
}
