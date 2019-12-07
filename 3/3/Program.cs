using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            begin:
            Console.Write("Введите месяц в числовом выражении от 1 до 12:");
            int month;
            try
            {
                month = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"Невозможно преобразовать в число ");
                goto begin;
            }
            
            if (month == 1 || month == 2 || month == 12)
            {
                Console.WriteLine("Зима");
            }
            else if (month==3 || month==4 || month==5)
            {
                Console.WriteLine("Весна");
            }
            else if (month==6 || month==7 || month==8)
            {
                Console.WriteLine("Лето");
            }
            else if (month==9 || month==10 || month==11)
            {
                Console.WriteLine("Зима");
            }
            else
            {
                Console.WriteLine("На этой планете такого месяца нет");
            }
            Console.ReadKey();
            
        }
    }
}
