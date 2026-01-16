using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Area_Calculator.Shapes
{
    internal class Rectangle : IShape
    {
        public double Area { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public virtual void CalculateArea()
        {
            Area = Length * Width;
        }

    }
}
