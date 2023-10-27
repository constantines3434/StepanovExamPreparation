using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class DieselCar : ICar
    {
        public void Move()
        {
            Console.WriteLine("Движется дизельная машина");
        }
    }
}
