//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
class NumberComparer
{
    static void Main()
    {
        double firstNumber = Double.Parse(Console.ReadLine());
        double secondNumber = Double.Parse(Console.ReadLine());
        double result = Math.Max(firstNumber, secondNumber);
        Console.WriteLine(result);
    }
}
