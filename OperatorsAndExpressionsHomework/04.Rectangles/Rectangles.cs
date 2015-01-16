//Write an expression that calculates rectangle’s perimeter and area by given width and height.
using System;
class Rectangles
{
    static void Main()
    {
        double width = Double.Parse(Console.ReadLine());
        double height = Double.Parse(Console.ReadLine());
        double perimeter = 2 * (width + height);
        double area = width * height;
        Console.WriteLine(perimeter);
        Console.WriteLine(area);
    }
}
