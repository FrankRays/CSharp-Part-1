//
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
        string smallBlock = "";
        string bigBlock = "";
        string exchangedBitNumber = "";
        try
        {
            if (bitRepresentation.Length < 27)
            {
                bitRepresentation = bitRepresentation.PadLeft(27, '0');
            }
            for (int i = lowIndex + increment; i >= lowIndex; i--)
            {
                smallBlock += Convert.ToString(bitRepresentation[bitRepresentation.Length - 1 - i]);
            }
            for (int j = highIndex + increment; j >= highIndex; j--)
            {
                bigBlock += Convert.ToString(bitRepresentation[bitRepresentation.Length - 1 - j]);
            }
            for (int k = 0; k < bitRepresentation.Length - 1 - highIndex - increment; k++)
            {
                exchangedBitNumber += Convert.ToString(bitRepresentation[k]);
            }
            exchangedBitNumber += smallBlock;
            for (int l = bitRepresentation.Length - highIndex; l < bitRepresentation.Length - 1 - lowIndex - increment; l++)
            {
                exchangedBitNumber += Convert.ToString(bitRepresentation[l]);
            }
            exchangedBitNumber += bigBlock;
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
        Main();
    }
}
