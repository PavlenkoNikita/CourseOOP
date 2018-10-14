using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    class Equilateral_triangle : Triangle
    {
        public Equilateral_triangle(double a, ref List<string> logs) : base(a, a, 60, ref logs)
        {
            logs.Add("Вызван конструктор класса Равностороннего треугольника.");

            Type = "Равносторонний";

            C = a;
        }

        public override double Square() => Math.Sqrt(3) * A * A / 4;

        public override double Perimetr() => A * 3;

        public override void Dispose(ref List<string> logs)
        {
            logs.Add("Вызван деструктор класса Равностороннего треугольника.");

            base.Dispose(ref logs);
        }
    }
}
