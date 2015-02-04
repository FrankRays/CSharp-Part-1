//Write an expression that checks for given integer if its third digit from right-to-left is 7.
using System;
class ThirdDigitIs7
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        bool isSeven = (number / 100) % 10 == 7;
        Console.WriteLine(isSeven);
    }
}
