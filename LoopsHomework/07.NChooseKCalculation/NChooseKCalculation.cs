//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops.

using System;
class NChooseKCalculation
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
        ulong numeratorBase = UInt64.Parse(Console.ReadLine());
        ulong denominatorBase = UInt64.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(numeratorBase) / (Factorial(denominatorBase) * Factorial(numeratorBase - denominatorBase)));
    }
}
