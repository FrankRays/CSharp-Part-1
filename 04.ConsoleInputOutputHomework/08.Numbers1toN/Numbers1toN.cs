//Write a program that reads an integer number n from the console 
//and prints all the numbers in the interval [1..n], each on a separate line.

using System;
class Numbers1toN
{
    static void Main()
    {
        int upperLimit = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= upperLimit; i++)
        {
            Console.WriteLine(i);
        }
    }
}
