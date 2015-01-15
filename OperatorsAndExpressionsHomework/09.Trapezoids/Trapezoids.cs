//Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;
class Trapezoids
{
    static void Main()
    {
        double smallBase = Double.Parse(Console.ReadLine());
        double largeBase = Double.Parse(Console.ReadLine());
        double height = Double.Parse(Console.ReadLine());
        double area = (smallBase + largeBase) * height * 0.5;
        Console.WriteLine(area);
    }
}
