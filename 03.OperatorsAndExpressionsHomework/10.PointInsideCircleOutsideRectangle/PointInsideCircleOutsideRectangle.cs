//Write an expression that checks for given point (x, y) if it is within the circle 
//K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
using System;
class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        double abscissa = Double.Parse(Console.ReadLine());
        double ordinate = Double.Parse(Console.ReadLine());
        bool isInsideCircle = Math.Pow(abscissa - 1, 2) + Math.Pow(ordinate - 1, 2) <= 2.25;
        bool isOutsideRectangle = !(-1 <= abscissa && abscissa <= 5 && -1 <= ordinate && ordinate <= 1);
        Console.WriteLine(isInsideCircle&&isOutsideRectangle);
    }
}
