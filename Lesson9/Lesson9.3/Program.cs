using System;

namespace Lesson9._3
{
    class Program
    {
        // Программа разбивает строку на массив строк, и переводит их в нижний регистр

        static void Main(string[] args)
        {
            string s = "Login1,LOgin2,login3,loGin4";
            string[] array = s.Split(",");
            string x = "";

            foreach (string el in array)
            {
                x += el;
            }

            x = x.ToLower();

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
