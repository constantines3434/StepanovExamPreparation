using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder
{
    interface IBuilder
    {
        public void SetId(int id);
        public void SetName(string name);
    }
}
