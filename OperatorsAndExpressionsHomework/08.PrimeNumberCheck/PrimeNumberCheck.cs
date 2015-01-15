//Write an expression that checks if given positive integer number n is prime.
using System;
class PrimeNumberCheck
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }
        }
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
