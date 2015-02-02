using System;
class AngryFemaleGPS
{
    static void Main()
    {
        //input
        long input = Math.Abs(long.Parse(Console.ReadLine()));
        long sumOfOddDigits = 0;
        long sumOfEvenDigits = 0;

        //solution
        while (input != 0)
        {
            long currentDigit = input % 10;
            if (currentDigit % 2 == 0)
            {
                sumOfEvenDigits += currentDigit;
            }
            else
            {
                sumOfOddDigits += currentDigit;
            }
            input /= 10;
        }

        //output
        if (sumOfOddDigits==sumOfEvenDigits)
        {
            Console.WriteLine("straight {0}", sumOfEvenDigits);
        }
        else if(sumOfEvenDigits>sumOfOddDigits)
        {
            Console.WriteLine("right {0}", sumOfEvenDigits);
        }
        else if(sumOfOddDigits>sumOfEvenDigits)
        {
            Console.WriteLine("left {0}", sumOfOddDigits);
        }
    }
}

