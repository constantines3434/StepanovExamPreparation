using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Subscriber
    {
        public void Subscribe(ref Publisher publisher) =>
            publisher.Notify += Send;
        public void Unsubscribe(ref Publisher publisher) =>
            publisher.Notify += Send;

        public void Send(object sender, string message) =>
            Console.WriteLine($"Отправить сообщение от подписчика: {message}");
    }
}
