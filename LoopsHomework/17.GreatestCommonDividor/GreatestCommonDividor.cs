//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;
class GreatestCommonDividor
{
    static void Main()
    {
        int numberA = int.Parse(Console.ReadLine());
        int numberB = int.Parse(Console.ReadLine());
        int max = 0;
        int min = 0;
        while (numberA != numberB)
        {
            max = Math.Max(Math.Abs(numberA), Math.Abs(numberB));
            min = Math.Min(Math.Abs(numberA), Math.Abs(numberB));
            max -= min;
            numberA = max;
            numberB = min;
        }
        Console.WriteLine(max);
    }
}
