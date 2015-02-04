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

        //Digit counting starts from right to left.
        int firstDigit = number % 10;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = (number / 100) % 10;
        int fourthDigit = number / 1000;

        int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;
        int reversedDigitsOrder = firstDigit * 1000 + secondDigit * 100 + thirdDigit * 10 + fourthDigit;
        int lastDigitInFront = firstDigit * 1000 + number / 10;
        int exchangedThirdAndSecondDigit = fourthDigit * 1000 + thirdDigit * 10 + secondDigit * 100 + firstDigit;

        Console.WriteLine(sumOfDigits);
        Console.WriteLine(reversedDigitsOrder);
        Console.WriteLine(lastDigitInFront);
        Console.WriteLine(exchangedThirdAndSecondDigit);
    }
}
