using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    class Right_triangle : Triangle
    {
        public Right_triangle(double a, double b, double angle) : base (a, b, angle) 
        {
            A = a;
            B = b;
            Angle = angle;
        }

        public override double Square() => A * B / 2;
        public override double Perimetr() => A + B + Math.Sqrt(A * A + B * B);
    }
}
