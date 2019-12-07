using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            begin:
            Console.Write("Введите день недели в числовом выражении от 1 до 7 :");
            string day = Console.ReadLine();
            switch (day)
            {
                case "1":
                    Console.WriteLine("Понедельник");
                    break;
                case "2":
                    Console.WriteLine("Вторник");
                    break;
                case "3":
                    Console.WriteLine("Среда");
                    break;
                case "4":
                    Console.WriteLine("Четверг");
                    break;
                case "5":
                    Console.WriteLine("Пятница");
                    break;
                case "6":
                    Console.WriteLine("Суббота");
                    break;
                case "7":
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Такого дня недели не существует");
                    goto begin;
            }

            Console.ReadKey();
        }
    }
}
