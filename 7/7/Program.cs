using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {

            begin:
            Console.Write("Введите натуральное число:");
            string str = Console.ReadLine();
            uint n;
            if (!uint.TryParse(str, out n ))
            {
                Console.WriteLine("Проверьте правильность введения числа");
                goto begin;
            }
            //int n = int.Parse(Console.ReadLine());
            bool result = true;

            for (var i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    result = false;
                    Console.WriteLine("Число не является простым");
                    break;
                }
                else
                {
                    result = true;
                }

                Console.WriteLine($"Является ли число простым {result} ");
                Console.ReadLine();
            }
        }
    }
}
