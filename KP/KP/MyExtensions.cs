using System;

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
                                 $"Сторона c: {string.Format("{0:f2}", triangle.C)}\n" +
                                 $"Угол между a и b: {string.Format("{0:f2}", triangle.Angle * 180 / Math.PI)}°\n\n" +
                                 $"Периметр: {string.Format("{0:f2}", triangle.Perimetr())}\n" +
                                 $"Площадь: {string.Format("{0:f2}", triangle.Square())}");
        }
    }
}
