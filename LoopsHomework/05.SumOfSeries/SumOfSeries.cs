//Write a program that, for a given two integer numbers n and x, 
//calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the decimal point.
using System;
class SumOfSeries
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
        double sumOfSeries = 1;
        int sumationIndex = int.Parse(Console.ReadLine());
        int sumationBase = int.Parse(Console.ReadLine());
        for (int i = 1; i <= sumationIndex; i++)
        {
            sumOfSeries = sumOfSeries + (Factorial(i)) / (Math.Pow(sumationBase, i));
        }
        Console.WriteLine("{0:0.00000}",sumOfSeries);
    }
}
