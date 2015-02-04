//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
class OddAndEvenProduct
{
    static void Main()
    {
        string[] userInput = Console.ReadLine().Split();
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < userInput.Length; i++)
        {
            if (i % 2 == 0)
                oddProduct *= Convert.ToInt32(userInput[i]);
            else
                evenProduct *= Convert.ToInt32(userInput[i]);
        }
        Console.WriteLine(oddProduct == evenProduct);
    }
}
