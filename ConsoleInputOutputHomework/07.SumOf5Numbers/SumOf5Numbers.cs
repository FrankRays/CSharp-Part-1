//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
class SumOf5Numbers
{
    static void Main()
    {
        //Dibides the input into an array of strings.
        string[] userInput = Console.ReadLine().Split();

        double sum = 0;

        //Converts each string array element to double and
        //calculates the sum.
        for (int i = 0; i < userInput.Length; i++)
        {
            sum += Convert.ToDouble(userInput[i]);
        }

        Console.WriteLine(sum);
    }
}
