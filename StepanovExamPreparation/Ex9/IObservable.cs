using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    interface IObservable
    {
        public void Subscribe(IObserver observer);
        public void UnSubscribe(IObserver observer);
        public void Notify(double Price);
    }
}
