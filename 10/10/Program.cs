using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            begin:
            Console.WriteLine("Введите число N, на которое хотите увидеть таблицу умножения: ");
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Введите число цифрами");
                goto begin;
            }
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i=0; i<nums.Length;i++)
            {
                int result = nums[i] * n;
                Console.WriteLine($"{nums[i]} * {n} = {result} ");
            }
            Console.ReadLine();
        }
    }
}
