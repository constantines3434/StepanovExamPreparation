using System;
using System.Runtime.CompilerServices;

namespace StepanovExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber1 = new Subscriber();
            Subscriber subscriber2 = new Subscriber();

            subscriber1.Subscribe(publisher);
            subscriber2.Subscribe(publisher);
            publisher?.DoSomething(); // Вызываем действие, которое приводит к вызову события

            publisher.Notify -= subscriber1.Send;

            publisher?.DoSomething();
        }
    }
}