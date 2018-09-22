using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    class Equilateral_triangle : Triangle
    {
        public Equilateral_triangle(double a, double b, double angle) : base(a, b, angle)
        {
            A = a;
            B = b;
            Angle = angle;
        }

        public override double Square()
        {
            return Math.Sqrt(3)*A*A/4;
        }
        public override double Perimetr()
        {
            return A*3;
        }
    }
}
