//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
using System;
class SumOfNNumbers
{
    static void Main()
    {
        int numberOfInputs = Int32.Parse(Console.ReadLine());
        double sumOfInputs = 0;
        for (int i = 0; i < numberOfInputs; i++)
        {
            sumOfInputs += Double.Parse(Console.ReadLine());
        }
        Console.WriteLine(sumOfInputs);
    }
}
