using System;
using System.Numerics;
class BitFlipper
{
    public static string ConvertToBinary(ulong value)
    {
        if (value == 0) return "0";
        System.Text.StringBuilder b = new System.Text.StringBuilder();
        while (value != 0)
        {
            b.Insert(0, ((value & 1) == 1) ? '1' : '0');
            value >>= 1;
        }
        b.Insert(0, '0');
        return b.ToString().PadLeft(65,'0');
    }
    static void Main()
    {
        //INPUT
        char[] input = ConvertToBinary(ulong.Parse(Console.ReadLine())).ToCharArray();

        //SOLUTION
        for (int i = 2; i < input.Length - 1; i++)
        {
            int currentBit = input[i] - '0';
            int previousBit = input[i - 1] - '0';
            int nextBit = input[i + 1] - '0';
            if (currentBit == 1 && previousBit == 1 && nextBit == 1)
            {
                input[i-1] = '0';
                input[i] = '0';
                input[i+1] = '0';
                i += 2;
                continue;
            }
            if (currentBit == 0 && previousBit == 0 && nextBit == 0)
            {
                input[i - 1] = '1';
                input[i] = '1';
                input[i + 1] = '1';
                i += 2;
                continue;
            }
        }
        //OUTPUT
        string result = new string(input);
        result = result.Remove(0,1);
        Console.WriteLine(Convert.ToUInt64(result,2));
    }
}
