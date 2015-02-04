using System;
class SevenlandNumbers
{
    static void Main()
    {
        //INPUT
        string inputNumber = Console.ReadLine();

        //SOLUTION
        int baseTenNumber = 0;
        for (int i = inputNumber.Length - 1; i >= 0; i--)
        {
            baseTenNumber += (inputNumber[i] - '0') * (int)Math.Pow(7, inputNumber.Length - 1 - i);
        }

        baseTenNumber++;

        string reversed = "";
        while (baseTenNumber > 0)
        {
            reversed += (baseTenNumber % 7).ToString();
            baseTenNumber /= 7;
        }

        //OUTPUT
        for (int i = reversed.Length - 1; i >= 0; i--)
        {
            Console.Write(reversed[i]);
        }
        Console.WriteLine();
    }
}