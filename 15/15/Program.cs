using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("У гусей и кроликов вместе 64 лапы.");
            Console.WriteLine("Возможные сочетания гусей и кроликов:");
            int rab = 16;
            int goose = 0;

            for (int i = 0; i < 17; i++)
            {                
                Console.WriteLine($"Гусей {goose} - Кроликов {rab}");
                rab--;
                goose += 2;
            }
                                 
            Console.ReadLine();
            
        }
    }
}
