using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    class Equilateral_triangle : Triangle
    {
        public Equilateral_triangle(double a) : base(a, a, 60)
        {
            A = a;
            B = a;
            C = a;
            Angle = 60;
        }

        public override double Square() => Math.Sqrt(3) * A * A / 4;
        public override double Perimetr() => A * 3;
    }
}
