using System;

namespace PatternBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("34");
            
            Builder builder = new Builder();
            Director director = new Director(builder);
            Console.WriteLine($"Директо приказал изготовить продукт №{director.Lopata().Id}\n" +
                $"с названием {director.Lopata().Name} ");
            //director.Bread();
        }
    }
}