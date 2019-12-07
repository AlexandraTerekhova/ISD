using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            begin:
            Console.WriteLine("Введите пароль:");
            string pas = Console.ReadLine();
            if (pas != "root")
            {
                Console.WriteLine("Пароль неверный! Повторите попытку");
                Console.ReadKey();
                goto begin;
            }
            else
            {
                Console.WriteLine("Пароль правильный");
            }
            Console.ReadKey();
        }
    }
}
