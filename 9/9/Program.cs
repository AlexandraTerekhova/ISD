using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            begin:
            Console.Write("Выберите валюту из которой вы конвертируете Dollar или Euro или Grn: ");
            string val = Console.ReadLine();
            const double RateDolToGrn = 24;
            const double RateEuroToGrn = 30;
            double RateEuroToDol = (RateEuroToGrn / RateDolToGrn);
            double SumInDol, SumInEuro, SumInGrn = 0;
            double money;
        begin1:
            Console.Write("Введите сумму для конвертации:");
            string str = Console.ReadLine();
            if (!double.TryParse(str,out money))
            {
                Console.WriteLine("Введите сумму цифрами");
                goto begin1;
            }

            //double money = double.Parse(Console.ReadLine());
            switch (val)
            {
                case "Dollar":
                    SumInEuro = (money / RateEuroToDol);
                    SumInGrn = money * RateDolToGrn;
                    Console.WriteLine($"Сумма в евро {SumInEuro} , Сумма в гривне {SumInGrn}");
                    break;
                case "Euro":
                    SumInDol = money * RateEuroToDol;
                    SumInGrn = money * RateEuroToGrn;
                    Console.WriteLine($"Сумма в долларах {SumInDol}, Сумма в гривнах {SumInGrn}");
                    break;
                case "Grn":
                    SumInEuro = money / RateEuroToGrn;
                    SumInDol = money / RateDolToGrn;
                    Console.WriteLine($"Сумма в евро {SumInEuro}, Сумма в долларах {SumInDol}");
                    break;
                default:

                    Console.WriteLine("Пожалуйста, введите валюту верно");
                    goto begin;
            
            } 
            Console.ReadLine();
        }    
    
    }
}
