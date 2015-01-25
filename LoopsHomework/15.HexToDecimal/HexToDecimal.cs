//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
class HexToDecimal
{
    static void Main()
    {
        string hexForm = Console.ReadLine();
        long decimalForm = 0;
        for (int i = hexForm.Length - 1; i >= 0; i--)
        {
            long multiplier = 0;
            switch(hexForm[i])
            {
                case '0': multiplier = 0; break;
                case '1': multiplier = 1; break;
                case '2': multiplier = 2; break;
                case '3': multiplier = 3; break;
                case '4': multiplier = 4; break;
                case '5': multiplier = 5; break;
                case '6': multiplier = 6; break;
                case '7': multiplier = 7; break;
                case '8': multiplier = 8; break;
                case '9': multiplier = 9; break;
                case 'A': multiplier = 10; break;
                case 'B': multiplier = 11; break;
                case 'C': multiplier = 12; break;
                case 'D': multiplier = 13; break;
                case 'E': multiplier = 14; break;
                case 'F': multiplier = 15; break;
                default: break;
            }
            decimalForm += (long)((multiplier) * Math.Pow(16, (hexForm.Length - 1 - i)));
        }
        Console.WriteLine(decimalForm);
    }
}
