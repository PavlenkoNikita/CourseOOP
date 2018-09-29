﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    class Arbitrary_triangle : Triangle
    {
        public Arbitrary_triangle(double a, double b, double angle) : base(a, b, angle)
        {
            C = Math.Sqrt(A * A + B * B - 2 * A * B * Math.Cos(Angle));
        }

        public override double Square() => A * B / 2 * Math.Sin(Angle);
        public override double Perimetr() => A + B + C;
    }
}
