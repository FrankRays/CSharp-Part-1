//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
using System;
class CombinatoricsCalculation
{
    static int Factorial(int number)
    {
        int factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    static void Main()
    {
        int numeratorBase = int.Parse(Console.ReadLine());
        int denominatorBase = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(numeratorBase)/Factorial(denominatorBase));
    }
}
