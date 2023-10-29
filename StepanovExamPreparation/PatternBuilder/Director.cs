using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder
{
    public class Director
    {
        private Builder builder;

        public Director(Builder _builder)
        {
            builder = _builder;
        }

        public Product Lopata()
        {
            builder.SetId(1);
            builder.SetName("Лопата");
            return builder.Build();
        }

        public Product Bread()
        {
            builder.SetId(2);
            builder.SetName("Bread");
            return builder.Build();
        }
    }
}
