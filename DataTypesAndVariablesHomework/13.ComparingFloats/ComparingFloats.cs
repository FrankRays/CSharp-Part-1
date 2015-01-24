//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
using System;
class ComparingFloats
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal eps = 1E-6M;
        Console.WriteLine("Approximately equal (precision 1E-6)?");
        Console.WriteLine(Math.Abs(a - b) < eps);
    }
}