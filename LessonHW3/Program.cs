using System;

namespace LessonHW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя три целочисленных значения и найти максимальное.

            Console.WriteLine("Введите 3 целых числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"Максиальное число {a} ");
            }

            else if (b > a && b > c)
            {
                Console.WriteLine($"Максиальное число {b} ");
            }

            else if (c > b && c > a)
            {
                Console.WriteLine($"Максиальное число {c} ");
            }
                    
            Console.ReadLine();
        }
    }
}
