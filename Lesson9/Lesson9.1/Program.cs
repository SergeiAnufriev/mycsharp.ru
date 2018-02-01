using System;

namespace Lesson9._1
{
    class Program
    {
        // Программа заменяет в строке имя "Nikolay" на "Oleg"

        static void Main(string[] args)
        {
            string s = "Nikolay, Ivan, Pert, Vladimir, Nikolay, Aleksandr";
            string change = s.Replace("Nikolay", "Oleg");

            Console.WriteLine(change);
            Console.ReadKey();
        }
    }
}
