using System;

namespace Lesson6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Программа для проверки введённого пороля
            string password;
            do
            {
                Console.Write("Enter password:");
                password = Convert.ToString(Console.ReadLine());
            }
            while (password != "root");



        }
    }
}
