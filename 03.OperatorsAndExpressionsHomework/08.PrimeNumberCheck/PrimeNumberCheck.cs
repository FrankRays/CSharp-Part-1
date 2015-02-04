//Write an expression that checks if given positive integer number n is prime.
using System;
class PrimeNumberCheck
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        bool isPrime = true;

        //Makes a check whether the number is divisible by anything
        //in between 1 and itself;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }
        }

        //Handles the exceptions.
        if (number <= 1)
        {
            Console.WriteLine(!isPrime);
        }
        else
        {
            Console.WriteLine(isPrime);
        }
    }
}
