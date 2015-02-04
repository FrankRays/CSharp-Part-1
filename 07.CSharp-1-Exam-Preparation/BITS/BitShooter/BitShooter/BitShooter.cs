using System;
class BitShooter
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
        return b.ToString().PadLeft(64, '0');
    }
    static void Main()
    {
        //INPUT
        char[] input = ConvertToBinary(ulong.Parse(Console.ReadLine())).ToCharArray();

        //SOLUTION
        int left = 0;
        int right = 0;
        for (int i = 0; i < 3; i++)
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');
            int shootCenter = Convert.ToInt32(inputNumbers[0]);
            int shootSize = Convert.ToInt32(inputNumbers[1]);
            for (int j = 0; j <= shootSize / 2; j++)
            {
                if (shootCenter - j >= 0)
                    input[63 - shootCenter + j] = '0';
                if (shootCenter + j <= 63)
                    input[63 - shootCenter - j] = '0';
            }
        }
        for (int i = 0; i < 32; i++)
        {
            if (input[i] == '1')
                left++;
            if (input[63 - i] == '1')
                right++;
        }
        //OUTPUT
        Console.WriteLine("left: {0}", left);
        Console.WriteLine("right: {0}", right);
    }
}
