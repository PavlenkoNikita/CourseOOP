using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public class Picture
    {
        public List<Triangle> Array { get; private set; }

        public List<string> Logs { get; set; }


        public Picture()
        {
            Array = new List<Triangle>();

            Logs = new List<string>();
        }

        public void Add(Triangle triangle) => Array.Add(triangle);

        public void Remove(int index) => Array.Remove(Array[index]);

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < Array.Count; i++)
            {
                result += $"{i + 1}) {MyExtensions.GetTriangleInfo(Array[i])}\n";
            }

            result += string.Format("\nСумма площадей треугольников:{0:f2}", SumSquare());

            return result;
        }

        public double SumSquare() => Array.Select(x => x.Square()).Sum();
    }
}
