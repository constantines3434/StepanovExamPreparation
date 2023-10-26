using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    [Serializable]
    class Data<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }

        public double ExchangeRate { get; set; }
        public Data(T Id, string Name, double ExchangeRate)
        {
            this.Id = Id;
            this.Name = Name;
            this.ExchangeRate = ExchangeRate;
        }
    }
}
