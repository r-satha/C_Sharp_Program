﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Shape
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is {Name}");
            
        }
        public abstract double Area();
    }
}
