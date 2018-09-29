using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public static class MyExtensions
    {
        public static double ToRadians(this double angle) => angle * Math.PI / 180;
    }
}
