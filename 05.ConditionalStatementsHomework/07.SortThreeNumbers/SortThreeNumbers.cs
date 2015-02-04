//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;
class SortThreeNumbers
{
    static void Main()
    {
        double firstNumber = Double.Parse(Console.ReadLine());
        double secondNumber = Double.Parse(Console.ReadLine());
        double thirdNumber = Double.Parse(Console.ReadLine());
        double temporary;
        if (firstNumber >= secondNumber)
        {
            if (secondNumber >= thirdNumber) { }
            else
            {
                if (firstNumber >= thirdNumber)
                {
                    temporary = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = temporary;
                }
                else
                {
                    temporary = firstNumber;
                    firstNumber = thirdNumber;
                    thirdNumber = temporary;
                }
                if (secondNumber <= thirdNumber)
                {
                    temporary = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = temporary;
                }
            }
        }
        else
        {
            temporary = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temporary;
            if (secondNumber >= thirdNumber) { }
            else
            {
                if (firstNumber >= thirdNumber)
                {
                    temporary = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = temporary;
                }
                else
                {
                    temporary = firstNumber;
                    firstNumber = thirdNumber;
                    thirdNumber = temporary;
                }
                if (secondNumber <= thirdNumber)
                {
                    temporary = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = temporary;
                }
            }
        }
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        Console.WriteLine(thirdNumber);
    }
}
