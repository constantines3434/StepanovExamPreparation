using System;
using System.IO;

namespace Ex13 
{
    class Program
    {
        static void Main(string[] args)
        {
            Days days = Days.Monday | Days.Tuesday;
            Console.WriteLine("Рабочие дни: " + days);

            if (days == Days.Wednesday)
            {
                Console.WriteLine("Среда - рабочий день");
            }

            //добавление
            days = days | Days.Saturday;

            Console.WriteLine("День недели " + days);

            //удаление
            days = days & ~Days.Saturday;

            Console.WriteLine("День недели " + days);
        }
    }
}
