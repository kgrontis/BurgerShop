﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeftechee.Entities
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Litre { get; set; }
        public decimal Price { get; set; }
    }
}
