//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Collections.Generic;
class RandomizeNumbers
{
    static void Main()
    {
        int maxValue = int.Parse(Console.ReadLine());

        //Here will be stored the randomized sequence
        //so that there are no repetitions of numbers on the list.
        List<int> randomOrderedNumbers = new List<int>();

        int value;
        Random newGenerator = new Random();
        for (int i = 1; i <= maxValue; i++)
        {
            //Generates more random numbers while the currently
            //generated one is already on the list.
            do value = newGenerator.Next(1, maxValue + 1);
            while (randomOrderedNumbers.Contains(value));

            //Adds the new random number to the list
            //and prints it at the same time.
            randomOrderedNumbers.Add(value);
            Console.WriteLine("{0} ",value);
        }
    }
}
