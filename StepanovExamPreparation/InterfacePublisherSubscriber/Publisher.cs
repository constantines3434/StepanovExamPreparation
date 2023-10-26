using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePublisherSubscriber
{
    class Publisher : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Что-то произошло у Издателя");
        }
    }
}
