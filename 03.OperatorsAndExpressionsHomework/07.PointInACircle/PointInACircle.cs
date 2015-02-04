//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
using System;
class PointInACircle
{
    static void Main()
    {
        double abscissa = Double.Parse(Console.ReadLine());
        double ordinate = Double.Parse(Console.ReadLine());
        bool isInsideCircle = Math.Pow(abscissa, 2) + Math.Pow(ordinate, 2) <= 4;
        Console.WriteLine(isInsideCircle);
    }
}
