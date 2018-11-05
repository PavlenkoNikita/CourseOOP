using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace KP
{
    [DataContract]
    [KnownType(typeof(Equilateral_triangle)),
    KnownType(typeof(Isosceles_triangle)),
    KnownType(typeof(Right_triangle)),
    KnownType(typeof(Arbitrary_triangle))]
    public abstract class Triangle : IDisposable
    {
        [DataMember]
        private double angle;

        [DataMember]
        public string Type { get; protected set; }
        [DataMember]
        public double A { get; protected set; }
        [DataMember]
        public double B { get; protected set; }
        [DataMember]
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
