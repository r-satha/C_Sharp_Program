using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double width, double height)
        {
            Name = "Rectangle";
            Length = width; 
            Width = height;
        }
        public override double Area()
        {
            return Length * Width;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a Length of {Length} and Width of {Width} ");
        }
    }
}
