//Write a program that reads a number n and prints on the console 
//the first n members of the Fibonacci sequence (at a single line, separated by comma and space -, )
using System;
class FibonacciNummbers
{
    static void Main()
    {
        int firstMember = 0;
        int secondMember = 1;
        int temporary;
        int nthMember = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < nthMember; i++)
        {
            temporary = firstMember;
            Console.Write("{0}, ", firstMember);
            firstMember = secondMember;
            secondMember += temporary;
        }
        Console.WriteLine();
    }
}
