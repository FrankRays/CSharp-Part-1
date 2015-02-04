using System;
class BitBall
{
    static void Main()
    {
        //INPUT
        int height = 8;
        int width = 8;
        int[,] matrix = new int[height, width];
        for (int row = 0; row < height; row++)
        {
            string number = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] = number[col] - '0';
            }
        }
        for (int row = 0; row < height; row++)
        {
            string number = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
            for (int col = 0; col < width; col++)
            {
                if (number[col] == '1')
                {
                    if (matrix[row, col] == 1)
                    {
                        matrix[row, col] = 0;
                    }
                    else
                    {
                        matrix[row, col] = 2;
                    }
                }
            }
        }

        //SOLUTION
        int goalsX = 0;
        int goalsY = 0;
        bool isYplayer = false;
        bool isXplayer = false;
        int topRowX = -1;
        int topRowY = -1;
        int bottomRowX = -1;
        int bottomRowY = -1;

        for (int col = 0; col < width; col++)
        {
            for (int row = 0; row < height; row++)
            {
                if (matrix[height - 1 - row, col] == 2)
                {
                    isYplayer = true;
                    topRowY = height - 1 - row;
                }
                if (matrix[row, col] == 2)
                {
                    isYplayer = true;
                    bottomRowY = row;
                }
                if (matrix[row, col] == 1)
                {
                    isXplayer = true;
                    topRowX = row;
                }
                if (matrix[height - 1 - row, col] == 1)
                {
                    isXplayer = true;
                    bottomRowX = height - 1 - row;
                }
            }

            if ((isYplayer && !isXplayer) || (isYplayer && isXplayer && topRowY < bottomRowX))
            {
                goalsY++;
            }
            if ((isXplayer && !isYplayer) || (isXplayer && isYplayer && topRowX > bottomRowY))
            {
                goalsX++;
            }
            isXplayer = false;
            isYplayer = false;
            topRowX = -1;
            topRowY = -1;
        }

        //OUTPUT
        Console.WriteLine("{0}:{1}", goalsX, goalsY);
        //for (int row = 0; row < height; row++)
        //{
        //    for (int col = 0; col < width; col++)
        //    {
        //        Console.Write(matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}
    }
}