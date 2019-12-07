using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int money;
            begin:
            Console.Write("Введите вашу ставку:");
            try
            {
                money = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите, пожалуйста, ставку в цифрах");
                goto begin;
            }
            Random rnd = new Random();
            int result = rnd.Next(1,12);
            Console.WriteLine($"На кубике выпало {result}");
            if (result >=1 && result <= 5)
            {
                sum = 0 * money;
            }
            else if (result>=6 && result<=8)
            {
                sum = money;
            }
            else if (result>=9 && result<=11)
            {
                sum = money * 2;
            }
            else
            {
                sum = money * 10;
            }
            Console.WriteLine($"Вы выиграли {sum} ");
            Console.WriteLine("Хотите продолжить игру? 'да' или 'нет'"); 
            string str = Console.ReadLine();
            switch (str)
            {
                case "да":
                    goto begin;
                case "нет":
                    break;
                default:
                    break;
            }
            Console.ReadKey();

        }
    }
}
