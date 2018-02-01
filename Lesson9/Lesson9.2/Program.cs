using System;

namespace Lesson9._2
{
    class Program
    {
        // Программа выводит на экран часть текста, из строки

        static void Main(string[] args)
        {
            string s = "Сегодня мы с вами рассмотрели, как работать со строками в Си-шарп. Были описаны основные операторы и методы, которые используются для работы со строками";
            string excerpt = s.Substring(67, 40);

            Console.WriteLine(excerpt);
            Console.ReadKey();
        }
    }
}
