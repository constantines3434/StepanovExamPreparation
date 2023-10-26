using System;

namespace InterfacePublisherSubscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher= new Publisher();
            Subscriber subscriber= new Subscriber();

            subscriber.Subscribe(publisher);
            publisher.Update();
            subscriber.Notify();
        }
    }
}