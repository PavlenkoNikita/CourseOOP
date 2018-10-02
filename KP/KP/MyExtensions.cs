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

        public static string GetTriangleInfo(this Triangle triangle)
        {
            return string.Format($"Тип треугольника: {triangle.Type}\n\n" +
                                 $"Сторона а: {triangle.A}\n" +
                                 $"Сторона b: {triangle.B}\n" +
                                 $"Сторона c: {triangle.C.ToString("#.##")}\n" +
                                 $"Угол между a и b: {(triangle.Angle * 180 / Math.PI).ToString("#.##")}°\n\n" +
                                 $"Периметр: {triangle.Perimetr().ToString("#.##")}\n" +
                                 $"Площадь: {triangle.Square().ToString("#.##")}");
        }
    }
}
