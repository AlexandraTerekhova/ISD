using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваш питомец говорит 'мяу' или 'гав'? : ");
            begin:
            string ans = Console.ReadLine();
                        
            switch (ans)
            {
                case "мяу":
                    Console.WriteLine("Покорми кота");
                    break;
                case "гав":
                    Console.WriteLine("Погуляй с собакой");
                    break;
                default:
                    Console.Write("Введите, пожалуйста 'мяу' или 'гав' : ");
                    goto begin;
                                                         
            }

            Console.ReadKey();
            
        }
    }
}
