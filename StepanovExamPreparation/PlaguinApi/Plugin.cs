using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaguinApi
{
    public class Plugin : IPlugin
    {
        public void Execute()
        {
            Console.WriteLine("Plugin 1 is executed.");
        }
    }
}
