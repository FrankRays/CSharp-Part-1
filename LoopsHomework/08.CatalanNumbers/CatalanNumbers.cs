//Write a program to calculate the nth Catalan number by given n (1 < n < 100).
using System;
class CatalanNumbers
{
    static double Factorial(double number)
    {
        double factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    static void Main()
    {
        ulong numberBase = UInt64.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(2 * numberBase) / (Factorial(numberBase + 1) * Factorial(numberBase)));
    }
}

