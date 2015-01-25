//Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

using System;
class MinMaxSumAvg
{
    static void Main()
    {
        int numberOfInputs = int.Parse(Console.ReadLine());
        int currentNumber;
        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        int sum = 0;
        float avg;
        for (int i = 0; i < numberOfInputs; i++)
        {
            currentNumber = int.Parse(Console.ReadLine());
            if (min > currentNumber)
            {
                min = currentNumber;
            }
            if (max < currentNumber)
            {
                max = currentNumber;
            }
            sum += currentNumber;
        }
        avg = (float)sum / numberOfInputs;
        Console.WriteLine(min);
        Console.WriteLine(max);
        Console.WriteLine(sum);
        Console.WriteLine("{0:0.00}",avg);
    }
}