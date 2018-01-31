using System;
using System.Collections.Generic;

namespace Lesson8._3
{
    class Program
    {
        // Программа, которая с помощью функции "FibonacciNumber" возврашает указанный элемент ряда Фибоначчи

        public static int FibonacciNumber(int index)
        {
            int  i, x, y, z;

            i = 0;
            x = 0;
            y = 1;
            z = 0;

            for (i = 0; i < index; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }

            return (x);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements of the Fibonacci series:");
            int index = Convert.ToInt32(Console.ReadLine());
            int element = FibonacciNumber(index);
            Console.WriteLine(element);
            Console.ReadKey();
        }
    }
}
