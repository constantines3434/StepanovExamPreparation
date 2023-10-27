using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Car
    {
        public string Name { get; set; }
        public Car(string Name) => this.Name = Name;
        public ICar TypeCar { get; set; }
        public void Move()
        {
            TypeCar.Move();
        }
    }
}
