//Write a program that enters from the console a positive integer n 
//and prints all the numbers from 1 to n, on a single line, separated by a space.

using System;
class Numbers1toN
{
    static void Main()
    {
        int limit = int.Parse(Console.ReadLine());
        for (int i = 1; i <= limit; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}
