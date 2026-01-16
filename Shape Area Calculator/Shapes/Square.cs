using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Area_Calculator.Shapes
{
    internal class Square : IShape
    {
        public double Length { get; set; }
        public double Area { get; set; }
        public Square(double length)
        {
            Length = length;
        }
        public virtual void CalculateArea()
        {
            Area = Length * Length;
        }
    }
}
