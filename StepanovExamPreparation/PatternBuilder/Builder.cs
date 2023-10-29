using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder
{
    public class Builder : IBuilder
    {
        Product product = new Product();
        public void SetId(int id)
        {
            product.Id = id;   
        }

        public void SetName(string name)
        {
            product.Name = name;
        }

        public Product Build()
        {
            return product;
        }
    }
}
