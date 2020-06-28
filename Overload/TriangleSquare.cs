using System;
namespace Overload
{
    public class TriangleSquare
    {
        public static double GetSquare(double ab, double bc, double ac)
        {
            return 0;
        }

        public static double GetSquare(double h, double b)
        {
            return 0;
        }

        public static double GetSquare(double ab, double ac, int alpha)
        {
            double alphaRads = alpha * Math.PI / 180;
            return 0.5 * ab * ac * Math.Sin(alphaRads);
        }
    }
}
