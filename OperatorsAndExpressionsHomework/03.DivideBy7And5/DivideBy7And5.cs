//Write a Boolean expression that checks for given integer 
//if it can be divided (without remainder) by 7 and 5 at the same time.
using System;
class DivideBy7And5
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        bool isDivisible = number % 5 == 0 && number % 7 == 0;
        Console.WriteLine(isDivisible);
    }
}
