﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace Ex14
{
    [Serializable]
   public class Data
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? ExchangeRates { get; set; }
    }
}
