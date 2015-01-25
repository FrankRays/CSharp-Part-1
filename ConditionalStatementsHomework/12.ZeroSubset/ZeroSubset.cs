//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.

using System;
using System.Collections.Generic;
using Combinatorics.Collections;

//Combinatorics Library for .NET
//https://www.nuget.org/packages/Combinatorics

class ZeroSubset
{
    static void Main()
    {
        List<int> setOfNumbers = new List<int>();
        for (int i = 0; i < 5; i++) setOfNumbers.Add(int.Parse(Console.ReadLine()));
        bool isZero = false;
        Combinations<int> combinationsOfTwo = new Combinations<int>(setOfNumbers, 2, GenerateOption.WithoutRepetition);
        foreach (var number in combinationsOfTwo)
        {
            if (number[0] + number[1] == 0)
            {
                Console.WriteLine(string.Join(" + ", number) + " = 0");
                isZero = true;
            }
        }
        Combinations<int> combinationsOfThree = new Combinations<int>(setOfNumbers, 3, GenerateOption.WithoutRepetition);
        foreach (var number in combinationsOfThree)
        {
            if (number[0] + number[1] + number[2] == 0)
            {
                Console.WriteLine(string.Join(" + ", number) + " = 0");
                isZero = true;
            }
        }
        Combinations<int> combinationsOfFour = new Combinations<int>(setOfNumbers, 4, GenerateOption.WithoutRepetition);
        foreach (var number in combinationsOfFour)
        {
            if (number[0] + number[1] + number[2] + number[3] == 0)
            { 
                Console.WriteLine(string.Join(" + ", number) + " = 0");
                isZero = true;
            }
        }
        if (setOfNumbers[0] + setOfNumbers[1] + setOfNumbers[2] + setOfNumbers[3] + setOfNumbers[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", setOfNumbers[0], setOfNumbers[1], setOfNumbers[2], setOfNumbers[3], setOfNumbers[4]);
        }
        if(isZero==false)
        {
            Console.WriteLine("No zero subset.");
        }
    }
}
