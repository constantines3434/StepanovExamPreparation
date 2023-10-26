using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepanovExamPreparation
{
    class Publisher
    {
        public event EventHandler<string> Notify;
        public void DoSomething()
        {
            Notify.Invoke(this, "Some happened in Publisher");
        }
    }
}
