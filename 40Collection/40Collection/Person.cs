﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Collection
{
    class Person
    {
        public string Name { get; set; }
        
        public string YearOfBirth { get; set; }

        public double Weight { get; set; }

        public Person(string Name, string YearOfBirth, double Weight)
        {
            this.Name = Name;
            this.YearOfBirth = YearOfBirth;
            this.Weight = Weight;
        }
    }
}
