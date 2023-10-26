using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Player
    {
        public int heartPoint;
        public void GetHeartPoint(ref int HeartPoint)
        {
            Console.WriteLine($"HP = {heartPoint}");
        }
        public void Fire(IWeapon weapon)
        {
            weapon.Fire(ref heartPoint);
        }
    }
}   
