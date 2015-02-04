using System;
namespace BullsAndCows
{
    class BullsAndCows
    {
        static void Main()
        {
            //INPUT
            int ourNumber = Math.Abs(int.Parse(Console.ReadLine()));
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());

            //SOLUTION
            bool flag = false;
            for (int i = 1000; i <= 9999; i++)
            {
                int bullsP = 0;
                int cowsP = 0;

                int number = ourNumber;
                int numberDigitD = number % 10;
                number /= 10;
                int numberDigitC = number % 10;
                number /= 10;
                int numberDigitB = number % 10;
                number /= 10;
                int numberDigitA = number % 10;

                int currentNumber = i;
                int currentD = currentNumber % 10;
                currentNumber /= 10;
                int currentC = currentNumber % 10;
                currentNumber /= 10;
                int currentB = currentNumber % 10;
                currentNumber /= 10;
                int currentA = currentNumber % 10;

                //Find all bulls and check digits out.
                if (currentA == numberDigitA)
                {
                    bullsP++;
                    numberDigitA = -1;
                    currentA = -1;
                }
                if (currentB == numberDigitB)
                {
                    bullsP++;
                    numberDigitB = -1;
                    currentB = -1;
                }
                if (currentC == numberDigitC)
                {
                    bullsP++;
                    numberDigitC = -1;
                    currentC = -1;
                }
                if (currentD == numberDigitD)
                {
                    bullsP++;
                    numberDigitD = -1;
                    currentD = -1;
                }

                //Find all cows and check 'em out.
                if (currentA != -1 && currentA == numberDigitB)
                {
                    cowsP++;
                    currentA = -1;
                    numberDigitB = -1;
                }
                if (currentA != -1 && currentA == numberDigitC)
                {
                    cowsP++;
                    currentA = -1;
                    numberDigitC = -1;
                }
                if (currentA != -1 && currentA == numberDigitD)
                {
                    cowsP++;
                    currentA = -1;
                    numberDigitD = -1;
                }

                if (currentB != -1 && currentB == numberDigitA)
                {
                    cowsP++;
                    currentB = -1;
                    numberDigitA = -1;
                }
                if (currentB != -1 && currentB == numberDigitC)
                {
                    cowsP++;
                    currentB = -1;
                    numberDigitC = -1;
                }
                if (currentB != -1 && currentB == numberDigitD)
                {
                    cowsP++;
                    currentB = -1;
                    numberDigitD = -1;
                }

                if (currentC != -1 && currentC == numberDigitA)
                {
                    cowsP++;
                    currentC = -1;
                    numberDigitA = -1;
                }
                if (currentC != -1 && currentC == numberDigitB)
                {
                    cowsP++;
                    currentC = -1;
                    numberDigitB = -1;
                }
                if (currentC != -1 && currentC == numberDigitD)
                {
                    cowsP++;
                    currentC = -1;
                    numberDigitD = -1;
                }

                if (currentD != -1 && currentD == numberDigitA)
                {
                    cowsP++;
                    currentD = -1;
                    numberDigitD = -1;
                }
                if (currentD != -1 && currentD == numberDigitB)
                {
                    cowsP++;
                    currentD = -1;
                    numberDigitB = -1;
                }
                if (currentD != -1 && currentD == numberDigitC)
                {
                    cowsP++;
                    currentD = -1;
                    numberDigitC = -1;
                }
                if (bullsP == bulls && cowsP == cows
                    && i % 10 != 0 && (i / 10) % 10 != 0 && (i / 100) % 10 != 0)
                {
                    flag = true;
                    Console.Write("{0} ", i); 
                }
            }
            if(flag == false)
                Console.WriteLine("No");
            Console.WriteLine();
        }
    }
}