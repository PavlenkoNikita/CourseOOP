using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    abstract class Triangle
    {
        public double A { get; protected set; }
        public double B { get; protected set; }
        public double Angle { get; protected set; }
         
        public Triangle(double a, double b, double angle)
        {
            A = a;
            B = b;
            Angle = angle;
        }

        public abstract double Square();
        public abstract double Perimetr();

    }
}
