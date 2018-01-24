using System;


namespace Lesson6._1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Программма для вывода на экран 20-ти последовательных чисел, с шагом 3

            int y = 0;

            for (int i = 1; i < 60; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();




        }
    }
}
