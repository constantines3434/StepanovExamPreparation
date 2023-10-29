using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ConsoleApp1
{
    public class User
    {
        [Required]
        [Range(15, 100)]
        public int Age { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Имя:");
            user.Name = Console.ReadLine();
            Console.WriteLine("Возраст: ");
            user.Age = Convert.ToInt32(Console.ReadLine());
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
        }
    }
}