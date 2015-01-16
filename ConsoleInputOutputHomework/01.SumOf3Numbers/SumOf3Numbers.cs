//Write a program that reads 3 real numbers from the console and prints their sum.
using System;
class SumOf3Numbers
{
    static void Main()
    {
        double firstNumber = Double.Parse(Console.ReadLine());
        double secondNumber = Double.Parse(Console.ReadLine());
        double thirdNumber = Double.Parse(Console.ReadLine());
        Console.WriteLine(firstNumber + secondNumber + thirdNumber);
        Main();
    }
}
