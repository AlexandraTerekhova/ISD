using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выберите 0 или 1:");
            string sel = Console.ReadLine();
            var a=sel=="0"? "Плохо":"Хорошо";
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
