using System;

namespace Ex5
{
    class Program
    {
    static void Main(string[] args)
        {
            GenericClass<int> first = new GenericClass<int>(1);
            int b = 1;
            int c = first.Value + b;

            GenericClass<string> second = new GenericClass<string>("Няя");
            string str = "Не";

            //if (second is string)
            //{
                Console.WriteLine($"{second.Value + str}");
            //}
        }
    }
}
    
