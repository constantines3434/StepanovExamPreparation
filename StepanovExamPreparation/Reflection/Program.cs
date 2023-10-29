using System;
using System.Reflection;
using Reflection;
namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Consta = new Person(1, "Consta");
            Type type = typeof(Person);

            foreach (PropertyInfo property in type.GetProperties())
            {
                Console.WriteLine($"{property.Name}, {property.PropertyType}");
            }

        }
    }
}

