﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarListApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public string Car_brand { get; set; }
        public string Car_model { get; set; }
        public int Color { get; set; }
        public int Year { get; set; }
    }
}
