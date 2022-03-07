using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите длину сторон");
            if (int.TryParse(Console.ReadLine(), out int a)
                && int.TryParse(Console.ReadLine(), out int b)
                && a > 0
                && b > 0)
                Console.WriteLine($"Площадь: {a * b}");
            else
                Console.WriteLine("введите корректные значения");
        }
    }
}
