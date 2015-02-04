//Write an expression that checks if given integer is odd or even.
using System;
class OddOrEven
{
    static void Main()
    {
        int numberInput = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Odd = {0}",numberInput % 2 != 0);
    }
}
