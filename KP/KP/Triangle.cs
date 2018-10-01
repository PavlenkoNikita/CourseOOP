using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    abstract class Triangle
    {
        private double angle;

        protected string Name { get; set; }
        protected double A { get; set; }
        protected double B { get; set; }
        protected double C { get; set; }
        protected double Angle { get { return angle.ToRadians(); }
                                 set {angle = value; } }

        public Triangle() { }
         
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
