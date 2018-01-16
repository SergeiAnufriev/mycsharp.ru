using System;

namespace Lesson4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Программа для игры с гостями
            int guest, home;
            Console.WriteLine("Guest goals:");
            guest = Convert.ToInt32(Console.ReadLine()); // Гости вводят число
            Console.WriteLine("Home goals:");
            home = Convert.ToInt32(Console.ReadLine()); //Хозяева вводят число

            if (guest > home)
            {
                Console.WriteLine("The guests won"); // Выиграли гости
            }
            else if (guest < home)
            {
                Console.WriteLine("Еhe hosts won"); // Выиграли хозяева
            }
            else 
            {
                Console.WriteLine("Draw"); // Ничья
            }

            Console.ReadKey();
            
        }
    }
}
