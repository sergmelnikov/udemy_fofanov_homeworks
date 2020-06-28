using System;
using Overload;

namespace Overload
{
    class Program
    {
        static void Main6(string[] args)
        {
            double result = TriangleSquare.GetSquare(ab: 5.9, ac: 3.6, alpha: 47);
            Console.WriteLine(result);

            double result2 = TriangleSquare.GetSquare(4, 6);
            Console.WriteLine(result2);


        }
    }
}
