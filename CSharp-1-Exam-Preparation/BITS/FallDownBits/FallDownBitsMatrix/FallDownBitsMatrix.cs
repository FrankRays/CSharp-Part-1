using System;
using System.Text;
class FallDownBitsMatrix
{
    static void Main()
    {
        int bits = 8;
        int[,] matrix = new int[bits, bits];

        //input
        for (int row = 0; row < bits; row++)
        {
            string num = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(bits, '0');
            for (int col = 0; col < bits; col++)
            {
                matrix[row, col] = Convert.ToInt32(num[col].ToString());
            }
        }

        //solution
        for (int col = 0; col < bits; col++)
        {
            int count = 0;
            for (int row = 0; row < bits; row++)
            {
                if (matrix[row, col] == 1)
                {
                    count++;
                    matrix[row, col] = 0;
                }
            }
            for (int row = 0; row < count; row++)
            {
                matrix[7 - row, col] = 1;
            }
        }

        //output
        Console.WriteLine();
        for (int row = 0; row < 8; row++)
        {
            StringBuilder sb = new StringBuilder();
            for (int col = 0; col < bits; col++)
            {
                sb.Append(matrix[row,col]);
            }
            Console.WriteLine(Convert.ToInt32(sb.ToString(),2));
        }
        Console.WriteLine();
    }
}

