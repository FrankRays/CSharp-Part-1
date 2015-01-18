//Write an expression that extracts from given integer n the value of given bit at index p.
using System;
class ExtractBitFromInteger
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        int position = Int32.Parse(Console.ReadLine());
        number = (number >> position) & 1;
        Console.WriteLine(number);
    }
}
