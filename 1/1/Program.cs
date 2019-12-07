using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите два числа:");
            begin1:
            Console.Write("Число 1: ");
            string str1 = (Console.ReadLine());
            int input1;
            if (!int.TryParse(str1,out input1))
            {
                Console.WriteLine("Введите, пожалуйста, цифры");
                goto begin1;
            }
            //int input1 = int.Parse(Console.ReadLine());
            begin2:
            Console.Write("Число 2: ");
            string str2 = (Console.ReadLine());
            int input2;
            if (!int.TryParse(str2, out input2))
            {
                Console.WriteLine("Введите, пожалуйста, цифры");
                goto begin2;
            }
            //int input2 = int.Parse(Console.ReadLine());

            if (input1 > input2)
            {
                Console.WriteLine($"Большее из этих чисел: {input1}");
            }
            else
            {
                Console.WriteLine($"Большее из этих чисел: {input2}");
            }
            Console.ReadLine();

         
        }
    }
}
