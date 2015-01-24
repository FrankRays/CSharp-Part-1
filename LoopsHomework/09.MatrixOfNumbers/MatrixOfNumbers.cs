//Write a program that reads from the console a positive integer number n (1 = n = 20) 
//and prints a matrix like in the example. Use two nested loops.
using System;
class MatrixOfNumbers
{
    static void Main()
    {
        int matrixLength = int.Parse(Console.ReadLine());
        for (int j = 0; j < matrixLength; j++)
        {
            for (int i = j+1; i <= matrixLength+j; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
