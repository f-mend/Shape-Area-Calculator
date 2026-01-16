using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Area_Calculator.Shapes
{
    internal class Circle : IShape
    {
        public double Radius { get; set; }
        public double Area { get; set; }

        public Circle (double radius)
        {
            Radius = radius;
        }
        public virtual void CalculateArea()
        {
            Area = Math.PI * (Radius * Radius);
        }
    }
}
