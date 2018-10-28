using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace KP
{
    [DataContract(Name = "Right")]
    class Right_triangle : Triangle
    {
        public Right_triangle(double a, double b, ref List<string> logs) : base (a, b, 90, ref logs) 
        {
            logs.Add("Вызван конструктор класса Прямоугольного треугольника.");

            Type = "Прямоугольный";

            C = Math.Sqrt(A * A + B * B);
        }

        public override double Square() => A * B / 2;

        public override double Perimetr() => A + B + C;

        public override void Dispose(ref List<string> logs)
        {
            logs.Add("Вызван деструктор класса Прямоугольного треугольника.");

            base.Dispose(ref logs);
        }
    }
}
