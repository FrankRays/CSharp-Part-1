//Write an if-statement that takes two double variables a and b and exchanges their values
//if the first one is greater than the second one. As a result print the values a and b, separated by a space.
using System;
class ExchangeIfGreater
{
    static void Main()
    {
        double firstNumber = Double.Parse(Console.ReadLine());
        double secondNumber = Double.Parse(Console.ReadLine());
        double temporary = 0;
        if (firstNumber > secondNumber)
        {
            temporary = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temporary;
        }
        Console.WriteLine("{0} {1}", firstNumber, secondNumber);
    }
}
