﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Case
    {
        private string manufacturer;

        public Case(string manufacturer)
        {
            this.Manufacturer = manufacturer;
        }

        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
    }
}