//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
using System;
class BitNo3
{
    static void Main()
    {
        int position = 3;
        int number = Int32.Parse(Console.ReadLine());
        number = (number >> position) & 1;
        Console.WriteLine(number);
    }
}
