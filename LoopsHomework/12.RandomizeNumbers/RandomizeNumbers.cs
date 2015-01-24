//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
using System;
using System.Collections.Generic;
class RandomizeNumbers
{
    static void Main()
    {
        int maxValue = int.Parse(Console.ReadLine());
        List<int> randomOrderedNumbers = new List<int>();
        int value;
        Random newGenerator = new Random();
        for (int i = 1; i <= maxValue; i++)
        {
            do value = newGenerator.Next(1, maxValue + 1);
            while (randomOrderedNumbers.Contains(value));
            randomOrderedNumbers.Add(value);
            Console.WriteLine("{0} ",value);
        }
    }
}
