using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Knife : IWeapon
    {
        public void Fire(ref int heartPoint)
        {
            Console.WriteLine("Удар ножом");
            heartPoint -= 1;
        }   
    }
}
