using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    class Picture
    {
        public List<Triangle> Array { private set; get; }

        public Picture()
        {
            Array = new List<Triangle>();
        }

        public void Add(Triangle triangle) => Array.Add(triangle);

        public void Remove(Triangle triangle) => Array.Remove(triangle);

        public void Show() { }

        public double SumSquare() => Array.Select(x => x.Square()).Sum();
    }
}
