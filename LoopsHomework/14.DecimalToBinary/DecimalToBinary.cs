//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
class DecimalToBinary
{
    static void Main()
    {
        long decimalForm = Int64.Parse(Console.ReadLine());
        string reversedBinaryForm = "";

        while (decimalForm != 0)
        {
            reversedBinaryForm += (decimalForm % 2).ToString();
            decimalForm /= 2;
        }

        for (int i = 0; i < reversedBinaryForm.Length; i++)
        {
            Console.Write(reversedBinaryForm[reversedBinaryForm.Length - 1 - i]);
        }
        Console.WriteLine();
    }

}
