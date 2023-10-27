using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    //Publisher
    class Observer : IObserver
    {
        private double Price  {get; set; }
        
        public Observer(double Price)
        {
            this.Price = Price;
            Console.WriteLine($"Цена на книгу изначально = {this.Price}");
        }
        public void Update(double Price)
        {
            this.Price = Price;
            Console.WriteLine($"Цена на книгу обновилась = {this.Price}");
        }
    }
}
