using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int LineSum = 0;
            int [] Line = new int [5];
            Console.WriteLine("Введите 5 чисел для расчета среднего арифметического:");
            
            for (int i = 0; i <= 4; i++)
            {
                try
                {
                    Line[i] = int.Parse(Console.ReadLine());

                    LineSum += Line[i];
                }
                catch (FormatException)
                {
                    break;
                }
            }
           
            double average = LineSum / 5.0;
            Console.WriteLine($"Среднее арифметическое этих чисел {average}");
            Console.ReadLine();
            
        }
    }
}
