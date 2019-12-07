using System;

namespace _10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число :");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while (n != 0)
            {
                n /= 10;
                count++;
            }
            Console.WriteLine($"Число разрядов этого числа: {count} ");
            Console.ReadLine();
        }
    }
}
