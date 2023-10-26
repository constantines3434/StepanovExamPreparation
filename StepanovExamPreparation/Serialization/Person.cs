﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person() { }
        public Person(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
