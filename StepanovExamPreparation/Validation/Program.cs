using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(0, "Consta");

            var validationContext = new ValidationContext(person);

            var validationResults = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(person, validationContext,
                                                      validationResults,
                                                      validateAllProperties: true);
            if (!isValid)
            {
                foreach (var validation in validationResults)
                {
                    Console.WriteLine(validation.ErrorMessage);
                }
            }

            Type type = typeof(Person);
            foreach(PropertyInfo property in type.GetProperties())
            {
                Console.WriteLine(property.Name, property.PropertyType);
            }
        }
    }
}