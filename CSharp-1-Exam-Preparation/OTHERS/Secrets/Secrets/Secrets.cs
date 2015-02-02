using System;
class Secrets
{
    public static int specialSum = 0;
    static void printLetter(int i)
    {
        for (int j = 0; j < specialSum % 10; j++)
        {
            if ((i + j + 1) % 27 == 0)
            {
                i++;
            }
            switch ((i + j + 1) % 27)
            {
                case 1: Console.Write("A"); break;
                case 2: Console.Write("B"); break;
                case 3: Console.Write("C"); break;
                case 4: Console.Write("D"); break;
                case 5: Console.Write("E"); break;
                case 6: Console.Write("F"); break;
                case 7: Console.Write("G"); break;
                case 8: Console.Write("H"); break;
                case 9: Console.Write("I"); break;
                case 10: Console.Write("J"); break;
                case 11: Console.Write("K"); break;
                case 12: Console.Write("L"); break;
                case 13: Console.Write("M"); break;
                case 14: Console.Write("N"); break;
                case 15: Console.Write("O"); break;
                case 16: Console.Write("P"); break;
                case 17: Console.Write("Q"); break;
                case 18: Console.Write("R"); break;
                case 19: Console.Write("S"); break;
                case 20: Console.Write("T"); break;
                case 21: Console.Write("U"); break;
                case 22: Console.Write("V"); break;
                case 23: Console.Write("W"); break;
                case 24: Console.Write("X"); break;
                case 25: Console.Write("Y"); break;
                case 26: Console.Write("Z"); break;
                default:
                    break;
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        //INPUT
        string inputNumber = Console.ReadLine();

        //SOLUTION
        int endPosition;
        if(inputNumber[0] == '-')
        {
            endPosition = inputNumber.Length - 1;
        }
        else
        {
            endPosition = inputNumber.Length;
        }
        for (int i = 1; i <= endPosition; i++)
        {
            if (i % 2 == 1)
            {
                specialSum += i * i * Convert.ToInt32(inputNumber[inputNumber.Length - i].ToString());
            }
            else
            {
                specialSum += i * Convert.ToInt32(inputNumber[inputNumber.Length - i].ToString()) 
                    * Convert.ToInt32(inputNumber[inputNumber.Length - i].ToString());
            }
        }

        //OUTPUT
        Console.WriteLine(specialSum);
        if (specialSum % 10 == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", inputNumber);
        }
        else
        {
            printLetter(specialSum % 26);
        }
    }
}
