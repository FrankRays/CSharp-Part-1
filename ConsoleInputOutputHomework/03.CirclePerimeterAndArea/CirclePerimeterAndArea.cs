//Write a program that reads the radius r of a circle and prints its circumference 
//and area formatted with 2 digits after the decimal point.

using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        double radius = Double.Parse(Console.ReadLine());
        double circumference = Math.Round(2 * Math.PI * radius, 2);
        double area = Math.Round(Math.PI * radius * radius, 2);
        Console.WriteLine(circumference);
        Console.WriteLine(area);
    }
}