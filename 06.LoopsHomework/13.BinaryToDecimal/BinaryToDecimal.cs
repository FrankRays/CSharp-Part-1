﻿//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
class BinaryToDecimal
{
    static void Main()
    {
        string binaryForm = Console.ReadLine();
        long decimalForm = 0;
        for (int i = binaryForm.Length - 1; i >= 0; i--)
        {
            decimalForm += (long)(Convert.ToInt32(new string(binaryForm[i], 1)) * Math.Pow(2, (binaryForm.Length-1 - i)));
        }
        Console.WriteLine(decimalForm);
    }
}
