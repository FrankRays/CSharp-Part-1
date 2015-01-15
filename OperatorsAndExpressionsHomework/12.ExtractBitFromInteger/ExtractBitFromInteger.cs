//Write an expression that extracts from given integer n the value of given bit at index p.
using System;
class ExtractBitFromInteger
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        int position = Int32.Parse(Console.ReadLine());
        if ((number & (int)Math.Pow(2, position)) == Math.Pow(2, position))
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
