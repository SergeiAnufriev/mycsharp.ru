using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Нахождение площади треугольника по теореме пифагора

            int katet1 = 5, katet2 = 7;   
            float area, hypotenuse, hypotenuse1;
            string str1 = "Area", str2 = "Hypotenuse", str3 = "Hypotenuse.cos";
            area = (katet1 * katet2) / 2f;

            // Нахожждение длинны гипотенузы
            hypotenuse = (float)  Math.Sqrt(Math.Pow(katet1, 2) + Math.Pow(katet2, 2));

            // Нахождение длинны гипотенузы по теореме косинусов
            hypotenuse1 = (float) Math.Sqrt(Math.Pow(katet1, 2) + Math.Pow(katet2, 2) - 2 * katet1 * katet2 * (Math.Cos(90 * Math.PI / 180)));


            Console.WriteLine( str1 + '=' + area);
            Console.WriteLine(str2 + '=' + hypotenuse);
            Console.WriteLine(str3 + '=' + hypotenuse1);
            Console.ReadKey();

           


        }
    }
}
