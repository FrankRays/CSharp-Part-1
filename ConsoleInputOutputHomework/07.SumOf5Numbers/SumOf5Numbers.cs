//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
using System;
class SumOf5Numbers
{
    static void Main()
    {
        string[] userInput = Console.ReadLine().Split();
        double sum = 0;
        for (int i = 0; i < userInput.Length; i++)
        {
            sum += Convert.ToDouble(userInput[i]);
        }
        Console.WriteLine(sum);
    }
}
