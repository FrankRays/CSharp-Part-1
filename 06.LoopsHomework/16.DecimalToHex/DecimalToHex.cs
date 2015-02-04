//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
class DecimalToHex
{
    static void Main()
    {
        long decimalForm = Int64.Parse(Console.ReadLine());
        string reversedHexForm = "";

        while (decimalForm != 0)
        {
            long remainder = decimalForm % 16;
            switch(remainder)
            {
                case 0: reversedHexForm += '0'; break;
                case 1: reversedHexForm += '1'; break;
                case 2: reversedHexForm += '2'; break;
                case 3: reversedHexForm += '3'; break;
                case 4: reversedHexForm += '4'; break;
                case 5: reversedHexForm += '5'; break;
                case 6: reversedHexForm += '6'; break;
                case 7: reversedHexForm += '7'; break;
                case 8: reversedHexForm += '8'; break;
                case 9: reversedHexForm += '9'; break;
                case 10: reversedHexForm += 'A'; break;
                case 11: reversedHexForm += 'B'; break;
                case 12: reversedHexForm += 'C'; break;
                case 13: reversedHexForm += 'D'; break;
                case 14: reversedHexForm += 'E'; break;
                case 15: reversedHexForm += 'F'; break;
                default: break;
            }
            decimalForm /= 16;
        }
        for (int i = 0; i < reversedHexForm.Length; i++)
        {
            Console.Write(reversedHexForm[reversedHexForm.Length - 1 - i]);
        }
        Console.WriteLine();
    }
}
