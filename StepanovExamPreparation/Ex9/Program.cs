using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] argv)
        {
            Observer Publisher = new Observer(1488);
            Observable Subscriber0 = new Observable();
            Observable Subscriber1 = new Observable();

            // Subscribe the observer to the observable
            Subscriber0.Subscribe(Publisher);
            Subscriber1.Subscribe(Publisher);


        }
    }   
}