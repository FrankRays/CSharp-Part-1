//Write a program that reads two positive integer numbers and prints how many 
//numbers p exist between them such that the reminder of the division by 5 is 0.

using System;
class DivisibleNumbersInInterval
{
    static void Main()
    {
        uint startNumber = UInt32.Parse(Console.ReadLine());
        uint endNumber = UInt32.Parse(Console.ReadLine());
        uint count = 0;
        for (uint i = startNumber; i <= endNumber; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
