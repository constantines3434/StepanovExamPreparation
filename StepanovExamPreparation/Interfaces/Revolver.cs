using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Revolver : IWeapon
    {
        public void Fire(ref int heartPoint)
        {
            Console.WriteLine("Выстрел из револьвера");
            heartPoint -= 3;
        }
    }
}
