using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    class Right_triangle : Triangle
    {
        public Right_triangle(double a, double b) : base (a, b, 90) 
        {
            Type = "Прямоугольный";
            C = Math.Sqrt(A * A + B * B);
        }

        public override double Square() => A * B / 2;
        public override double Perimetr() => A + B + C;
    }
}
