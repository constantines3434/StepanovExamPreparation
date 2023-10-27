using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    //Subscriber
    class Observable : IObservable
    {
        //список издательств
        //подписчик подписывается на разные издательства
        private List<IObserver> observers = new List<IObserver>();
        public void Subscribe(IObserver obs)
        {
            Console.WriteLine($"подпика на издательство ");
            observers.Add(obs);
        }
        public void UnSubscribe(IObserver obs)
        {
           
            observers.Remove(obs);
        }
        public void Notify(double Price)
        {
            foreach (var obs in observers)
            {   
                obs.Update(Price);
            }
        }
    }
}
