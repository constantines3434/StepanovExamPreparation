using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Persona<TValue1, TValue2>
    {
        public TValue1 Id { get; set; }
        public TValue2 Name { get; set; }

        public Persona(TValue1 Id, TValue2 Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public void AddToInt(int num)
        {
            if (typeof(TValue1) == typeof(int))
            {
                int currentValue = (int)(object)Id; // Преобразование в int
                int result = currentValue + num;
                Id = (TValue1)(object)result; // Преобразование обратно в тип T
            }
            else
            {
                throw new InvalidOperationException("Id is not of type int.");
            }
        }

        public TValue1 GetId()
        {
            return this.Id;
        }
    }
}
