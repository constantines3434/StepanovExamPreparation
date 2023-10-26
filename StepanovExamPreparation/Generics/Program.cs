using System;
using System.Collections.Generic;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona<int, string> Consta = new Persona<int, string>(1, "Consta");
            int constaId = Consta.Id;
            Console.WriteLine($"Id = {Consta.GetId()}, Name = {Consta.Name}");
        }
    }
}
