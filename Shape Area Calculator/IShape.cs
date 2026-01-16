using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Area_Calculator
{
    internal interface IShape
    {
        public double Area { get; set; }
        public abstract void CalculateArea();

    }
}
