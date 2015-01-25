using System;
class NaBabaMiSmetalnika
{
    static void Main()
    {
        //INPUT
        int width = int.Parse(Console.ReadLine());
        int height = 8;
        int[,] matrix = new int[height, width];

        long sumOfNumbers = 0;
        int emptyCols = 0;

        //SOLUTION
            //Fills the matrix with bits.
        for (int row = 0; row < height; row++)
        {
            string input = Convert.ToString(long.Parse(Console.ReadLine()), 2).PadLeft(width, '0');
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] = Convert.ToInt32(input[col].ToString());
            }
        }

            //Starts reading commands.
        string command = Console.ReadLine();
        while (command != "stop")
        {
            int fingerRow = 0;
            int fingerCol = 0;

            if (command != "reset")
            {
                fingerRow = int.Parse(Console.ReadLine());
                fingerCol = int.Parse(Console.ReadLine());
            }

                //Sets the correct position when outside the smetalnik.
            if (fingerCol < 0)
            {
                fingerCol = 0;
            }
            if (fingerCol >= width)
            {
                fingerCol = width - 1;
            }
            if (fingerRow < 0)
            {
                fingerRow = 0;
            }
            if (fingerRow >= height)
            {
                fingerRow = height - 1;
            }

            switch (command)
            {
                case "right":
                    {
                        for (int i = 0; i < width - 1 - fingerCol; i++)
                        {
                            for (int col = width - 1; col > fingerCol; col--)
                            {
                                if (matrix[fingerRow, col] == 0 && matrix[fingerRow, col - 1] == 1)
                                {
                                    matrix[fingerRow, col] = 1;
                                    matrix[fingerRow, col - 1] = 0;
                                }
                            }
                        }
                        break;
                    }
                case "left":
                    {
                        for (int i = 0; i < fingerCol; i++)
                        {
                            for (int col = 0; col < fingerCol; col++)
                            {
                                if (matrix[fingerRow, col] == 0 && matrix[fingerRow, col + 1] == 1)
                                {
                                    matrix[fingerRow, col] = 1;
                                    matrix[fingerRow, col + 1] = 0;
                                }
                            }
                        }
                        break;
                    }
                case "reset":
                    {
                        for (int i = 0; i < width; i++)
                        {
                            for (int col = 0; col < width - 1; col++)
                            {
                                for (int row = 0; row < height; row++)
                                {
                                    if (matrix[row, col] == 0 && matrix[row, col + 1] == 1)
                                    {
                                        matrix[row, col] = 1;
                                        matrix[row, col + 1] = 0;
                                    }
                                }
                            }
                        }
                        break;
                    }
            }
            command = Console.ReadLine();
        }

            //Finds the sum of all numbers in the matrix in decimal form.
        for (int row = 0; row < height; row++)
        {
            string sum = "";
            for (int col = 0; col < width; col++)
            {
                sum += matrix[row, col].ToString();
            }
            sumOfNumbers += Convert.ToInt64(sum, 2);
        }

            //Counts all the empty columns
        for (int col = 0; col < width; col++)
        {
            bool isEmptyCol = true;
            for (int row = 0; row < height; row++)
            {
                if (matrix[row, col] == 1)
                {
                    isEmptyCol = false;
                }
            }
            if (isEmptyCol)
            {
                emptyCols++;
            }
        }
        long result = sumOfNumbers * emptyCols;

        //OUTPUT
        Console.WriteLine(result);
    }
}