//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
using System;
class BitNo3
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        if ((number & 8)==8)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
