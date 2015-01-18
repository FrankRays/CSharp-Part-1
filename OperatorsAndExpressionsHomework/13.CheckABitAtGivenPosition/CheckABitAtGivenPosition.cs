//Write a Boolean expression that returns if the bit at position p 
//(counting from 0, starting from the right) in given integer number n, has value of 1.
using System;
class CheckABitAtGivenPosition
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        int position = Int32.Parse(Console.ReadLine());
        number = (number >> position) & 1;
        bool isBitEqualToOne = (number == 1);
        Console.WriteLine(isBitEqualToOne);
    }
}
