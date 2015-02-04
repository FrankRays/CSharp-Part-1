//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program 
//that prints the entire ASCII table of characters on the console (characters from 0 to 255).
using System;
using System.Text;
class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.ASCII;
        Console.BufferHeight = 255;
        for (byte counter = 0; counter < 255; counter++)
        {
            Console.Write("0x{0:X}  ", counter);
            Console.WriteLine(" {0}  ", (char)counter);
        }
    }
}