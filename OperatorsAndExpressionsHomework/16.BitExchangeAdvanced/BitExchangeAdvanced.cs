//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.
using System;
class BitExchangeAdvanced
{
    static void Main()
    {
        long number = Int64.Parse(Console.ReadLine());
        int lowIndex = Int32.Parse(Console.ReadLine());
        int highIndex = Int32.Parse(Console.ReadLine());
        int increment = Int32.Parse(Console.ReadLine()) - 1;
        int switchValue = 0;
        if (lowIndex > highIndex)
        {
            switchValue = lowIndex;
            lowIndex = highIndex;
            highIndex = switchValue;
        }
        string bitRepresentation = Convert.ToString(number, 2);
        string lowBlock = "";
        string highBlock = "";
        string exchangedBitNumber = "";
        try
        {
            if (bitRepresentation.Length < 27)
            {
                bitRepresentation = bitRepresentation.PadLeft(27, '0');
            }
            for (int i = lowIndex + increment; i >= lowIndex; i--)
            {
                lowBlock += Convert.ToString(bitRepresentation[bitRepresentation.Length - 1 - i]);
            }
            for (int j = highIndex + increment; j >= highIndex; j--)
            {
                highBlock += Convert.ToString(bitRepresentation[bitRepresentation.Length - 1 - j]);
            }
            for (int k = 0; k < bitRepresentation.Length - 1 - highIndex - increment; k++)
            {
                exchangedBitNumber += Convert.ToString(bitRepresentation[k]);
            }
            exchangedBitNumber += lowBlock;
            for (int l = bitRepresentation.Length - highIndex; l < bitRepresentation.Length - 1 - lowIndex - increment; l++)
            {
                exchangedBitNumber += Convert.ToString(bitRepresentation[l]);
            }
            exchangedBitNumber += highBlock;
            for (int m = bitRepresentation.Length - lowIndex; m < bitRepresentation.Length; m++)
            {
                exchangedBitNumber += Convert.ToString(bitRepresentation[m]);
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Out of Range.");
            Environment.Exit(1);
        }
        if (highIndex <= lowIndex + increment)
        {
            Console.WriteLine("Overlapping.");
            Environment.Exit(1);
        }
        Console.WriteLine(Convert.ToInt64(exchangedBitNumber, 2));
    }
}
