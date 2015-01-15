//Write a program that takes as input a four-digit number in format abcd and performs the following:
//1. Calculates the sum of the digits: a + b + c + d.
//2. Prints on the console the number in reversed order: dcba.
//3. Puts the last digit in the first position: dabc.
//4. Exchanges the second and the third digits: acbd.
//The number has always exactly 4 digits and cannot start with 0.
using System;
class FourDigitNumber
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        int sumOfDigits = number / 1000 + (number / 100) % 10 + (number / 10) % 10 + number % 10;
        int reversedDigitsOrder = (number % 10) * 1000 + ((number / 10) % 10) * 100 + ((number / 100) % 10) * 10 + number / 1000;
        int lastDigitInFront = (number % 10) * 1000 + number / 10;
        int exchangedThirdAndSecondDigit = number / 1000 * 1000 + ((number / 100) % 10) * 10 + ((number / 10) % 10) * 100 + number % 10;
        Console.WriteLine(sumOfDigits);
        Console.WriteLine(reversedDigitsOrder);
        Console.WriteLine(lastDigitInFront);
        Console.WriteLine(exchangedThirdAndSecondDigit);
    }
}
