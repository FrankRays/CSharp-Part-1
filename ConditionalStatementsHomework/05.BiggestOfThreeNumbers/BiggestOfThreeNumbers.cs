//Write a program that finds the biggest of three numbers.
using System;
class BiggestOfThreeNumbers
{
    static void Main()
    {
        double firstNumber = Double.Parse(Console.ReadLine());
        double secondNumber = Double.Parse(Console.ReadLine());
        double thirdNumber = Double.Parse(Console.ReadLine());

        //A solution without if-else statements:
        //Console.WriteLine(Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber));

        if (firstNumber > secondNumber)
        {
            if (secondNumber > thirdNumber) Console.WriteLine(firstNumber);
            else
            {
                if (firstNumber > thirdNumber) Console.WriteLine(firstNumber);
                else Console.WriteLine(thirdNumber);
            }
        }
        else
        {
            if (secondNumber < thirdNumber) Console.WriteLine(thirdNumber);
            else Console.WriteLine(secondNumber);
        }
    }
}
