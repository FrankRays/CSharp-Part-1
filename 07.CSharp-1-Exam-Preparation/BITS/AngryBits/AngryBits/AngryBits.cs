using System;
class AngryBits
{
    static void Main()
    {
        //INPUT
        int height = 10;
        int width = 18;
            //Fill a 2D array representing the bits.
        int[,] matrix = new int[height, width];
        for (int row = 1; row < height - 1; row++)
        {
            string input = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(16, '0');
            for (int col = 1; col < width - 1; col++)
            {
                matrix[row, col] = input[col - 1] - '0';
            }
        }

        //SOLUTION
        bool playerWon = true;
        int path = 0;
        int pigs = 0;
        int score = 0;
        for (int col = width / 2 - 1; col >= 1; col--)
        {
            for (int row = 1; row < height - 1; row++)
            {
            beginning:
                if (matrix[row, col] == 1)
                {
                    int x = row;
                    int y = col;
                    while (x > 1)
                    {
                        x--;
                        y++;
                        path++;
                        if (matrix[x, y] == 1)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    if (matrix[x + i - 1, y + j - 1] == 1 && y + j - 1 >= 9)
                                    {
                                        pigs++;
                                    }
                                    matrix[x + i - 1, y + j - 1] = 0;
                                }
                            }
                            score += (path * pigs);
                            path = 0;
                            pigs = 0;
                            matrix[row, col] = 0;
                            goto beginning;
                        }
                    }
                    while (x < height - 2 && y < width - 2)
                    {
                        x++;
                        y++;
                        path++;
                        if (matrix[x, y] == 1)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    if (matrix[x + i - 1, y + j - 1] == 1 && y + j - 1 >= 9)
                                    {
                                        pigs++;
                                    }
                                    matrix[x + i - 1, y + j - 1] = 0;
                                }
                            }
                            score += (path * pigs);
                            path = 0;
                            pigs = 0;
                            matrix[row, col] = 0;
                            break;
                        }
                    }
                }
                pigs = 0;
                path = 0;
            }
        }

        for (int row = 0; row < height - 1; row++)
        {
            for (int col = width / 2; col < width - 1; col++)
            {
                if (matrix[row, col] == 1)
                {
                    playerWon = false;
                }
            }
        }

        //OUTPUT
        if (playerWon)
        {
            Console.WriteLine("{0} {1}", score, "Yes");
        }
        else
        {
            Console.WriteLine("{0} {1}", score, "No");
        }
    }
}