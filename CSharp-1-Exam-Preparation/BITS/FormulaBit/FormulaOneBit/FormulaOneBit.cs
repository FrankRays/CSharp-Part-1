//80/100 points in BgCoder - 2 time limit hits

using System;
class FormulaOneBit
{
    static void Main()
    {
        //INPUT
        int[,] matrix = new int[10, 10];
        for (int row = 1; row < 9; row++)
        {
            string input = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
            for (int col = 1; col < 9; col++)
            {
                matrix[row, col] = input[col - 1] - '0';
            }
        }

        //SOLUTION
        int currentRow = 1;
        int currentCol = 8;
        string direction = "down";
        bool beenDown = false;
        bool beenLeft = false;
        bool beenUp = false;
        bool canGoDown = false;
        bool canGoUp = false;
        bool canGoLeft = false;

        int path = 0;
        int turns = 0;
        while (true)
        {
            if (currentCol == 1 && currentRow == 9)
            {
                break;
            }
            if(matrix[currentRow, currentCol]==1)
            {
                Console.WriteLine("No 0");
                return;
            }
            if (direction == "down")
            {
                while (currentRow < 9 && matrix[currentRow, currentCol] != 1)
                {
                    matrix[currentRow, currentCol] = 2;
                    currentRow++;
                    path++;
                    beenDown = true;
                }
                currentRow--;
                path--;
                turns++;
                if (currentCol > 1 && matrix[currentRow, currentCol - 1] != 1)
                {
                    direction = "left";
                }
                else
                {
                    break;
                }
            }
            if (direction == "left")
            {
                while (currentCol >= 1 && matrix[currentRow, currentCol] != 1)
                {
                    matrix[currentRow, currentCol] = 2;
                    currentCol--;
                    path++;
                    beenLeft = true;
                }
                currentCol++;
                path--;
                turns++;
                if (currentRow > 1 && matrix[currentRow - 1, currentCol] != 1 && beenDown)
                {
                    direction = "up";
                    beenDown = false;
                }
                else if (currentRow < 8 && matrix[currentRow + 1, currentCol] != 1 && beenUp)
                {
                    direction = "down";
                    beenUp = false;
                }
                else
                {
                    break;
                }
            }
            if(direction=="up")
            {
                while(currentRow>=1&&matrix[currentRow, currentCol]!=1)
                {
                    matrix[currentRow, currentCol] = 2;
                    currentRow--;
                    path++;
                    beenUp = true;
                }
                currentRow++;
                path--;
                turns++;
                if(currentCol>1&&matrix[currentRow, currentCol - 1]!=1)
                {
                    direction = "left";
                }
            }
        }

        //OUTPUT
        //for (int row = 0; row < 10; row++)
        //{
        //    for (int col = 0; col < 10; col++)
        //    {
        //        Console.Write(matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        if(currentCol == 1 && currentRow == 8)
        {
            Console.Write("{0} {1}",++path, --turns);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No {0}", ++path);
        }