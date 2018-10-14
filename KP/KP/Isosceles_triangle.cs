using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    class Isosceles_triangle : Triangle
    {
        public Isosceles_triangle(double a, double angle, ref List<string> logs) : base(a, a, angle, ref logs)
        {
            logs.Add("Вызван конструктор класса Равнобедренного треугольника.");

            Type = "Равнобедренный";

            C = Math.Sqrt(A * A + A * A - 2 * A * A * Math.Cos(Angle));
        }

        public override double Square() => A * A / 2 * Math.Sin(Angle);

        public override double Perimetr() => A * 2 + C;

        public override void Dispose(ref List<string> logs)
        {
            logs.Add("Вызван деструктор класса Равнобедренного треугольника.");

            base.Dispose(ref logs);
        }
    }
}
