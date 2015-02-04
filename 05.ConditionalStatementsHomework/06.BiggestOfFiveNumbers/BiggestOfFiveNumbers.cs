//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
class BiggestOfFiveNumbers
{
    static void Main()
    {
        double firstNumber = Double.Parse(Console.ReadLine());
        double secondNumber = Double.Parse(Console.ReadLine());
        double thirdNumber = Double.Parse(Console.ReadLine());
        double fourthNumber = Double.Parse(Console.ReadLine());
        double fifthNumber = Double.Parse(Console.ReadLine());
        if (Math.Max(firstNumber, secondNumber) > Math.Max(thirdNumber, fourthNumber))
        {
            if (Math.Max(thirdNumber, fourthNumber) > fifthNumber)
            {
                Console.WriteLine(Math.Max(firstNumber, secondNumber));
            }
            else
            {
                if (Math.Max(firstNumber, secondNumber) > fifthNumber)
                {
                    Console.WriteLine(Math.Max(firstNumber, secondNumber));
                }
                else
                {
                    Console.WriteLine(fifthNumber);
                }
            }
        }
        else
        {
            if (Math.Max(thirdNumber, fourthNumber) < fifthNumber)
            {
                Console.WriteLine(fifthNumber);
            }
            else
            {
                Console.WriteLine(Math.Max(thirdNumber, fourthNumber));
            }
        }
    }
}
