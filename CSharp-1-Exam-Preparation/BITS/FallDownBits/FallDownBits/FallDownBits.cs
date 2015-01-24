using System;
class FallDownBits
{
    static void Main()
    {
        int bits = 8;
        int[] nums = new int[bits];

        //Input
        for (int i = 0; i < 8; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        //Solution
        for (int i = 0; i < bits; i++)
        {
            for (int j = 7; j > 0; j--)
            {
                for (int position = 0; position < bits; position++)
                {
                    if ((nums[j] >> position & 1) == 0 && (nums[j - 1] >> position & 1) == 1)
                    {
                        nums[j] |= 1 << position;
                        nums[j - 1] ^= 1 << position;
                    }
                }
            }
        }

        //Output
        Console.WriteLine();
        foreach (var num in nums)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        //Console.WriteLine(Convert.ToString(n0,2).PadLeft(8,'0'));
        //Console.WriteLine(Convert.ToString(n1,2).PadLeft(8,'0'));
        //Console.WriteLine(Convert.ToString(n2,2).PadLeft(8,'0'));
        //Console.WriteLine(Convert.ToString(n3,2).PadLeft(8,'0'));
        //Console.WriteLine(Convert.ToString(n4,2).PadLeft(8,'0'));
        //Console.WriteLine(Convert.ToString(n5,2).PadLeft(8,'0'));
        //Console.WriteLine(Convert.ToString(n6,2).PadLeft(8,'0'));
        //Console.WriteLine(Convert.ToString(n7,2).PadLeft(8,'0'));
    }
}