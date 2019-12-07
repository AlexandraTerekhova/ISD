using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum=0;
            double dist, time;
            begin1:
            Console.Write("Введите расстояние в км:");
            try
            {
                dist = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите корректно расстояние");
                goto begin1;
            }
            begin2:
            Console.Write("Введите время простоя в мин:");
            try
            {
                time = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите корректно время простоя");
                goto begin2;
            }
            
            if (dist<=5 && time==0)
            {
                sum = 20;
            }
            else if (dist<=5 && time>0)
            {
                sum = 20 + time * 1;
            }
            else if (dist>5 && time==0)
            {
                sum = 20 + ((dist - 5) * 3);
            }
            else if (dist>5 && time>0)
            {
                sum = 20 + ((dist - 5) * 3) + (time * 1);
            }
            Console.WriteLine($"Стоимость поездки {sum} грн");
            Console.ReadLine();
        }
    }
}
