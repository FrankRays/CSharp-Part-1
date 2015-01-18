//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v of a bit at the position p 
//from the binary representation of a number n while preserving all other bits in n.
using System;
class ModifyBitAtPosition
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        int position = Int32.Parse(Console.ReadLine());
        int bitValue = Int32.Parse(Console.ReadLine());
        int mask;
        if (bitValue == 0)
        {
            mask = ~(1 << position);
            Console.WriteLine(number & mask);
        }
        else
        {
            mask = 1 << position;
            Console.WriteLine(number | mask);
        }
    }
}
