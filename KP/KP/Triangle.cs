using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public abstract class Triangle : IDisposable
    {
        private double angle;


        public string Type { get; protected set; }

        public double A { get; protected set; }

        public double B { get; protected set; }

        public double C { get; protected set; }

        public double Angle { get { return angle.ToRadians(); }
                              protected set { angle = value; } }


        public Triangle() { }
         
        public Triangle(double a, double b, double angle, ref List<string> logs)
        {
            logs.Add("Вызван конструктор базового класса.");

            A = a;

            B = b;

            Angle = angle;
        }

        public abstract double Square();

        public abstract double Perimetr();

        public void Dispose() { }

        public virtual void Dispose(ref List<string> logs)
        {
            logs.Add("Вызван деструктор базового класса.");

            Dispose();
        }
    }
}
