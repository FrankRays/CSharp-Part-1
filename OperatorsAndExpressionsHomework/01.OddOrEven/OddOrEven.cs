//Write an expression that checks if given integer is odd or even.
using System;
class OddOrEven
{
    static void Main()
    {
        Console.WriteLine(Int32.Parse(Console.ReadLine()) % 2 != 0);
    }
}
