using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePublisherSubscriber
{
    class Subscriber : IObservable
    {
        private List<IObserver> observers;
        public Subscriber()
        {
            observers = new List<IObserver>();    
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach(IObserver observer in observers)
                observer.Update();
        }
    }
}
