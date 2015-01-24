using System;
class SubsetSumsCount
{
    //Binary numbers as combinations.
    static void Main()
    {
        int desiredSum = 0;
        int numberOfInputs = 5;
        int[] numbers = new int[numberOfInputs];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxI = (int)Math.Pow(2, numberOfInputs) - 1;

        int count = 0;

        for (int i = 1; i <= maxI; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < numberOfInputs; j++)
            {
                int mask = 1 << j;
                int iAndMask = i & mask;
                int bit = iAndMask >> j;
                if (bit == 1)
                {
                    currentSum += numbers[j];
                }
            }
            if (currentSum == desiredSum)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
