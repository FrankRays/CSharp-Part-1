using System;
class Warhead
{
    static void Main()
    {
        //Fill the 2D integer array with the bomb circuit.
        int[,] matrix = new int[16, 16];
        for (int row = 0; row < 16; row++)
        {
            string inputLine = Console.ReadLine();
            for (int col = 0; col < 16; col++)
            {
                matrix[row, col] = inputLine[col] - '0';
            }
        }
        while (true)
        {
            string operation = Console.ReadLine();
            if (operation == "cut")
            {
                string wire = Console.ReadLine();
                int countRed = 0;
                int countBlue = 0;
                for (int row = 1; row < 15; row++)
                {
                    for (int col = 1; col < 8; col++)
                    {
                        int upRow = row - 1;
                        int downRow = row + 1;
                        int leftCol = col - 1;
                        int rightCol = col + 1;

                        bool topLeft = false;
                        bool topCenter = false;
                        bool topRight = false;
                        bool currentLeft = false;
                        bool currentRight = false;
                        bool bottomLeft = false;
                        bool bottonCenter = false;
                        bool bottomRight = false;

                        //Check if there is a capacitor.
                        if (upRow >= 0 && leftCol >= 0 && matrix[upRow, leftCol] == 1)
                            topLeft = true;
                        if (upRow >= 0 && matrix[upRow, col] == 1)
                            topCenter = true;
                        if (upRow >= 0 && rightCol <= 15 && matrix[upRow, rightCol] == 1)
                            topRight = true;
                        if (leftCol >= 0 && matrix[row, leftCol] == 1)
                            currentLeft = true;
                        if (rightCol <= 15 && matrix[row, rightCol] == 1)
                            currentRight = true;
                        if (downRow <= 15 && leftCol >= 0 && matrix[downRow, leftCol] == 1)
                            bottomLeft = true;
                        if (downRow <= 15 && matrix[downRow, col] == 1)
                            bottonCenter = true;
                        if (downRow <= 15 && rightCol <= 15 && matrix[downRow, rightCol] == 1)
                            bottomRight = true;

                        //Count all red capacitors.
                        if (topLeft && topCenter && topRight && currentLeft
                            && currentRight && bottomLeft && bottonCenter && bottomRight)
                        {
                            countRed++;
                        }
                    }
                }
                for (int row = 1; row < 15; row++)
                {
                    for (int col = 8; col < 15; col++)
                    {
                        int upRow = row - 1;
                        int downRow = row + 1;
                        int leftCol = col - 1;
                        int rightCol = col + 1;

                        bool topLeft = false;
                        bool topCenter = false;
                        bool topRight = false;
                        bool currentLeft = false;
                        bool currentRight = false;
                        bool bottomLeft = false;
                        bool bottonCenter = false;
                        bool bottomRight = false;

                        //Check if there is a capacitor.
                        if (upRow >= 0 && leftCol >= 0 && matrix[upRow, leftCol] == 1)
                            topLeft = true;
                        if (upRow >= 0 && matrix[upRow, col] == 1)
                            topCenter = true;
                        if (upRow >= 0 && rightCol <= 15 && matrix[upRow, rightCol] == 1)
                            topRight = true;
                        if (leftCol >= 0 && matrix[row, leftCol] == 1)
                            currentLeft = true;
                        if (rightCol <= 15 && matrix[row, rightCol] == 1)
                            currentRight = true;
                        if (downRow <= 15 && leftCol >= 0 && matrix[downRow, leftCol] == 1)
                            bottomLeft = true;
                        if (downRow <= 15 && matrix[downRow, col] == 1)
                            bottonCenter = true;
                        if (downRow <= 15 && rightCol <= 15 && matrix[downRow, rightCol] == 1)
                            bottomRight = true;

                        //Count all blue capacitors.
                        if (topLeft && topCenter && topRight && currentLeft
                            && currentRight && bottomLeft && bottonCenter && bottomRight)
                        {
                            countBlue++;
                        }
                    }
                }
                if (wire == "blue" || wire == "right")
                {
                    if (countBlue == 0)
                    {
                        Console.WriteLine(countRed);
                        Console.WriteLine("disarmed");
                    }
                    else
                    {
                        Console.WriteLine(countBlue);
                        Console.WriteLine("BOOM");
                    }
                }
                if(wire == "red" || wire == "left")
                {
                    if (countRed == 0)
                    {
                        Console.WriteLine(countBlue);
                        Console.WriteLine("disarmed");
                    }
                    else
                    {
                        Console.WriteLine(countRed);
                        Console.WriteLine("BOOM");
                    }
                }
                break;
            }
            if (operation == "hover" || operation == "operate")
            {
                int currentRow = int.Parse(Console.ReadLine());
                int currentCol = int.Parse(Console.ReadLine());
                if (operation == "hover")
                {
                    if (matrix[currentRow, currentCol] == 1)
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                }
                if (operation == "operate")
                {
                    if (matrix[currentRow, currentCol] == 1)
                    {
                        int count = 0;
                        for (int row = 1; row < 15; row++)
                        {
                            for (int col = 1; col < 15; col++)
                            {
                                int upRow = row - 1;
                                int downRow = row + 1;
                                int leftCol = col - 1;
                                int rightCol = col + 1;

                                bool topLeft = false;
                                bool topCenter = false;
                                bool topRight = false;
                                bool currentLeft = false;
                                bool currentRight = false;
                                bool bottomLeft = false;
                                bool bottonCenter = false;
                                bool bottomRight = false;

                                //Check if there is a capacitor.
                                if (upRow >= 0 && leftCol >= 0 && matrix[upRow, leftCol] == 1)
                                    topLeft = true;
                                if (upRow >= 0 && matrix[upRow, col] == 1)
                                    topCenter = true;
                                if (upRow >= 0 && rightCol <= 15 && matrix[upRow, rightCol] == 1)
                                    topRight = true;
                                if (leftCol >= 0 && matrix[row, leftCol] == 1)
                                    currentLeft = true;
                                if (rightCol <= 15 && matrix[row, rightCol] == 1)
                                    currentRight = true;
                                if (downRow <= 15 && leftCol >= 0 && matrix[downRow, leftCol] == 1)
                                    bottomLeft = true;
                                if (downRow <= 15 && matrix[downRow, col] == 1)
                                    bottonCenter = true;
                                if (downRow <= 15 && rightCol <= 15 && matrix[downRow, rightCol] == 1)
                                    bottomRight = true;

                                //Count all capacitors.
                                if (topLeft && topCenter && topRight && currentLeft
                                    && currentRight && bottomLeft && bottonCenter && bottomRight)
                                {
                                    count++;
                                }
                            }
                        }
                        Console.WriteLine("missed");
                        Console.WriteLine(count);
                        Console.WriteLine("BOOM");
                        break;
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

                        //Check if there is a capacitor.
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

                        //Remove the capacitor.
                        if (topLeft && topCenter && topRight && currentLeft
                            && currentRight && bottomLeft && bottonCenter && bottomRight)
                        {
                            for (int row = upRow; row <= downRow; row++)
                            {
                                for (int col = leftCol; col <= rightCol; col++)
                                {
                                    matrix[row, col] = 0;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
