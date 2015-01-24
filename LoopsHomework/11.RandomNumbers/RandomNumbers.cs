//Write a program that enters 3 integers n, min and max (min = max) and prints n random numbers in the range [min...max].
using System;
class RandomNumbers
{
    static void Main()
    {
        Random newGenerator = new Random();
        int numberOfNumbers = int.Parse(Console.ReadLine());
        int lowerLimit = int.Parse(Console.ReadLine());
        int upperLimit = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfNumbers; i++)
        {
            Console.Write("{0} ",newGenerator.Next(lowerLimit, upperLimit + 1));
        }
        Console.WriteLine();
    }
}
