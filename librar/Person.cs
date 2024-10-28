﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librar
{
    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        protected Person(string name)
        {
            Name = name;
        }
    }
}
