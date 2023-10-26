using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepanovExamPreparation
{
    class Subscriber
    {
        public void Subscribe(Publisher publisher) => publisher.Notify += Send;
        public void Send(object sender, string message)
            => Console.WriteLine($"Отправить сообщение от подписчика: {message}");
    }
}
