using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            begin:
            Console.Write("Введите натуральное число: ");
            int num;
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                goto begin;
            }
            Console.WriteLine($"Квадраты натуральных чисел меньшие {num} ");
            int i = 1;
            while ((i * i) < num)
            {
                Console.WriteLine($"Квадрат числа {i} равен: {i*i}");
                i++;
            }
            Console.ReadKey();  

        }
    }
}
