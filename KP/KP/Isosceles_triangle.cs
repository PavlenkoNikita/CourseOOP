using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    class Isosceles_triangle : Triangle
    {
        public Isosceles_triangle(double a, double b, double angle) : base(a, b, angle)
        {
            A = a;
            B = b;
            Angle = angle;
        }

        public override double Square()
        {
            return A * A / 2 * Math.Sin(Angle);
        }
        public override double Perimetr()
        {
            return A + B + Math.Sqrt(A * A + B * B - 2 * A * B * Math.Cos(Angle));
        }
    }
}
