﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class GenericClass<T>
    {
        public T Value { get; set; }
        public GenericClass(T Value)
        {
            this.Value = Value;
        }
    }
}
