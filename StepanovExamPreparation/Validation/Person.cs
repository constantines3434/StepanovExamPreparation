using System;
using System.ComponentModel.DataAnnotations;
namespace Validation
{
    public class Person
    {
        [Range(1, 5, ErrorMessage ="Ошибка: Интервал должен быть 1..5")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Имя обязательно к заполнению")]
        public string Name { get; set; }

        public Person(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
