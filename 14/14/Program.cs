using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] Line = new int[5];
            int LineSum = 0;
            Console.WriteLine("Сгенерируем числа для расчета среднего арифметического :");
            foreach (int i in Line)
            {
                Line[i] = rnd.Next(1,1000);
                Console.Write($" {Line[i]} ");
                LineSum += Line[i];
            }
            double average = LineSum / 5.0;
            Console.WriteLine($" \n Среднее арифметическое этих чисел :  {average} ");
            Console.ReadLine();
        }
    }
}
