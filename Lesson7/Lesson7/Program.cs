using System;

namespace Lesson7
{
    class Program
    {
        // Программа выводит на экран, с помощью цикла "Foreach" все элементы массива целых чисел, которые больше 20 и меньше 50.

        static void Main(string[] args)
        {
            int i = 0;

            while (i < 100)
            {
                int[] numbers = { i++ };

                foreach (int el in numbers)
                {

                    if (i < 21)
                        continue;

                    if (i > 50)
                        break;
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
