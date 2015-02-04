using System;
class GameOfPage
{
    static void Main()
    {
        //Fill the 2D integer array with the cookie tray.
        int[,] matrix = new int[16, 16];
        for (int row = 0; row < 16; row++)
        {
            string inputLine = Console.ReadLine();
            for (int col = 0; col < 16; col++)
            {
                matrix[row, col] = inputLine[col] - '0';
            }
        }

        decimal moneyToPay = 0;

        while (true)
        {
            string operation = Console.ReadLine();
            if (operation == "paypal")
            {
                Console.WriteLine("{0:F2}", moneyToPay);
                break;
            }
            if (operation == "what is" || operation == "buy")
            {
                int currentRow = int.Parse(Console.ReadLine());
                int currentCol = int.Parse(Console.ReadLine());
                if (operation == "what is")
                {
                    if (matrix[currentRow, currentCol] == 1)
                    {
                        int upRow = currentRow - 1;
                        int downRow = currentRow + 1;
                        int leftCol = currentCol - 1;
                        int rightCol = currentCol + 1;

                        bool isBrokenCookie = false;
                        bool topLeft = false;
                        bool topCenter = false;
                        bool topRight = false;
                        bool currentLeft = false;
                        bool currentRight = false;
                        bool bottomLeft = false;
                        bool bottonCenter = false;
                        bool bottomRight = false;

                        //Check if there is a cookie.
                        if (upRow >= 0 && leftCol >= 0 && matrix[upRow, leftCol] == 1)
                            topLeft = true;
                        if (upRow >= 0 && matrix[upRow, currentCol] == 1)
                            topCenter = true;
                        if (upRow >= 0 && rightCol <= 15 && matrix[upRow, rightCol] == 1)
                            topRight = true;
                        if (leftCol >= 0 && matrix[currentRow, leftCol] == 1)
                            currentLeft = true;
                        if (rightCol <= 15 && matrix[currentRow, rightCol] == 1)
                            currentRight = true;
                        if (downRow <= 15 && leftCol >= 0 && matrix[downRow, leftCol] == 1)
                            bottomLeft = true;
                        if (downRow <= 15 && matrix[downRow, currentCol] == 1)
                            bottonCenter = true;
                        if (downRow <= 15 && rightCol <= 15 && matrix[downRow, rightCol] == 1)
                            bottomRight = true;
                        if (topLeft && topCenter && topRight && currentLeft
                            && currentRight && bottomLeft && bottonCenter && bottomRight)
                        {
                            Console.WriteLine("cookie");
                            continue;
                        }

                        //Check if there is a crumb.
                        if (!topLeft && !topCenter && !topRight && !currentLeft
                            && !currentRight && !bottomLeft && !bottonCenter && !bottomRight)
                        {
                            Console.WriteLine("cookie crumb");
                            continue;
                        }

                        //Check if it is a broken cookie.
                        //Go through the whole tray
                        //and for every cookie found
                        //check if the given index is part of it.
                        for (int row = 1; row < 15; row++)
                        {
                            for (int col = 1; col < 15; col++)
                            {
                                int upRow1 = row - 1;
                                int downRow1 = row + 1;
                                int leftCol1 = col - 1;
                                int rightCol1 = col + 1;

                                bool topLeft1 = false;
                                bool topCenter1 = false;
                                bool topRight1 = false;
                                bool currentLeft1 = false;
                                bool currentRight1 = false;
                                bool bottomLeft1 = false;
                                bool bottonCenter1 = false;
                                bool bottomRight1 = false;

                                //Check if there is a cookie.
                                if (upRow1 >= 0 && leftCol1 >= 0 && matrix[upRow1, leftCol1] == 1)
                                    topLeft1 = true;
                                if (upRow1 >= 0 && matrix[upRow1, col] == 1)
                                    topCenter1 = true;
                                if (upRow1 >= 0 && rightCol1 <= 15 && matrix[upRow1, rightCol1] == 1)
                                    topRight1 = true;
                                if (leftCol1 >= 0 && matrix[row, leftCol1] == 1)
                                    currentLeft1 = true;
                                if (rightCol1 <= 15 && matrix[row, rightCol1] == 1)
                                    currentRight1 = true;
                                if (downRow1 <= 15 && leftCol1 >= 0 && matrix[downRow1, leftCol1] == 1)
                                    bottomLeft1 = true;
                                if (downRow1 <= 15 && matrix[downRow1, col] == 1)
                                    bottonCenter1 = true;
                                if (downRow1 <= 15 && rightCol1 <= 15 && matrix[downRow1, rightCol1] == 1)
                                    bottomRight1 = true;

                                //If a cookie is found, check the given indexes - are they part of it?
                                if ((!topLeft1 && topCenter1 && topRight1 && currentLeft1
                                    && currentRight1 && bottomLeft1 && bottonCenter1 && bottomRight1)
                                    || (!topCenter1 && topLeft1 && topRight1 && currentLeft1
                                    && currentRight1 && bottomLeft1 && bottonCenter1 && bottomRight1)
                                    || (!topRight1 && topLeft1 && topCenter1 && currentLeft1
                                    && currentRight1 && bottomLeft1 && bottonCenter1 && bottomRight1)
                                    || (!currentLeft1 && topLeft1 && topCenter1 && topRight1 && currentLeft1
                                    && bottomLeft1 && bottonCenter1 && bottomRight1)
                                    || (!currentRight1 && topLeft1 && topCenter1 && topRight1 && currentLeft1
                                    && bottomLeft1 && bottonCenter1 && bottomRight1)
                                    || (!bottomLeft && topLeft1 && topCenter1 && topRight1 && currentLeft1
                                        && currentRight1 && bottonCenter1 && bottomRight1)
                                    || (!bottonCenter1 && topLeft1 && topCenter1 && topRight1 && currentLeft1
                                        && currentRight1 && bottomLeft1 && bottomRight1)
                                    || (!bottomRight1 && topLeft1 && topCenter1 && topRight1 && currentLeft1
                                        && currentRight1 && bottomLeft1 && bottonCenter1))
                                {
                                    if (isBrokenCookie == false)
                                    {
                                        Console.WriteLine("broken cookie");
                                        isBrokenCookie = true;
                                    }
                                    break;
                                }
                                    //if (topLeft1 && topCenter1 && topRight1 && currentLeft1
                                    //    && currentRight1 && bottomLeft1 && bottonCenter1 && bottomRight1)
                                    //{
                                    //    if ((currentCol == leftCol1 && (currentRow == upRow1 || currentRow == row || currentRow == downRow1))
                                    //       || (currentCol == rightCol1 && (currentRow == upRow1 || currentRow == row || currentRow == downRow1))
                                    //       || (currentRow == upRow1 && (currentCol == leftCol1 || currentCol == col || currentCol == rightCol1))
                                    //       || (currentRow == downRow1 && (currentCol == leftCol1 || currentCol == col || currentCol == rightCol1)))
                                    //    {
                                    //        Console.WriteLine("broken cookie");
                                    //    }
                                    //}
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("smile");
                    }
                }
                if (operation == "buy")
                {
                    if (matrix[currentRow, currentCol] == 0)
                    {
                        Console.WriteLine("smile");
                    }
                    else
                    {
                        int upRow = currentRow - 1;
                        int downRow = currentRow + 1;
                        int leftCol = currentCol - 1;
                        int rightCol = currentCol + 1;

                        bool topLeft = false;
                        bool topCenter = false;
                        bool topRight = false;
                        bool currentLeft = false;
                        bool currentRight = false;
                        bool bottomLeft = false;
                        bool bottonCenter = false;
                        bool bottomRight = false;

                        //Check if there is a cookie.
                        if (upRow >= 0 && leftCol >= 0 && matrix[upRow, leftCol] == 1)
                            topLeft = true;
                        if (upRow >= 0 && matrix[upRow, currentCol] == 1)
                            topCenter = true;
                        if (upRow >= 0 && rightCol <= 15 && matrix[upRow, rightCol] == 1)
                            topRight = true;
                        if (leftCol >= 0 && matrix[currentRow, leftCol] == 1)
                            currentLeft = true;
                        if (rightCol <= 15 && matrix[currentRow, rightCol] == 1)
                            currentRight = true;
                        if (downRow <= 15 && leftCol >= 0 && matrix[downRow, leftCol] == 1)
                            bottomLeft = true;
                        if (downRow <= 15 && matrix[downRow, currentCol] == 1)
                            bottonCenter = true;
                        if (downRow <= 15 && rightCol <= 15 && matrix[downRow, rightCol] == 1)
                            bottomRight = true;

                        //Buy the cookie -> remove it from the tray.
                        if (topLeft && topCenter && topRight && currentLeft
                            && currentRight && bottomLeft && bottonCenter && bottomRight)
                        {
                            moneyToPay += 1.79M;
                            for (int row = upRow; row <= downRow; row++)
                            {
                                for (int col = leftCol; col <= rightCol; col++)
                                {
                                    matrix[row, col] = 0;
                                }
                            }
                        }

                        //If it is a crumb
                        else
                        {
                            Console.WriteLine("page");
                        }
                    }
                }
            }
        }
        //for (int row = 0; row < 16; row++)
        //{
        //    for (int col = 0; col < 16; col++)
        //    {
        //        Console.Write(matrix[row,col]);
        //    }
        //    Console.WriteLine();
        //}
    }
}

