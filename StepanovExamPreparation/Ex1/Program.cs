using System;

namespace Ex1
{
    class Program
    {
        //1)	Напишите программу,
        //в которой определено событие и выполнена подписка на него.Продемонстрируйте смысл событий.
        static void Main(string[] argv)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            Subscriber subscriber1 = new Subscriber();

            subscriber.Subscribe(ref publisher);
            subscriber1.Subscribe(ref publisher);

            publisher.DoSomething();

            subscriber1.Unsubscribe(ref publisher);
            publisher.DoSomething();
        }
    }
}