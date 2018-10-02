using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    class Isosceles_triangle : Triangle
    {
        public Isosceles_triangle(double a, double angle) : base(a, a, angle)
        {
            Type = "Равнобедренный";
            C = Math.Sqrt(A * A + A * A - 2 * A * A * Math.Cos(Angle));
        }

        public override double Square() => A * A / 2 * Math.Sin(Angle);
        public override double Perimetr() => A * 2 + C;
    }
}
