//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
using System;
class ComparingFloats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double eps = 1E-6;
        Console.WriteLine("Approximately equal (precision 1E-6)?");
        Console.WriteLine(Math.Abs(a - b) < eps);
    }
}