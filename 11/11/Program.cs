using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 146);
            begin:
            Console.WriteLine("Программа загадывает число от 1 до 146");
            Console.WriteLine("Попробуйте его угадать");
            begin1:
            Console.WriteLine("Ваш вариант: ");
            int x;
            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Напишите число цифрами");
                goto begin1;
            }
            if (x < 1 || x > 146)
            {
                Console.WriteLine("Напоминаю, число должно быть от 1 до 146");
                goto begin1;
            }
            else if (x==number)
            {
                Console.WriteLine("Поздравляю!!! Вы угадали");
            }
            else if (x>number)       
            {
                Console.WriteLine("В этот раз не получилось, попробуйте меньшее число)))");
                goto begin1;
            }
            else
            {
                Console.WriteLine("В этот раз не получилось, попробуйте большее число)))");
                goto begin1;
            }
            Console.ReadKey();
        }
    }
}
