//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
using System;
using System.Text;
class IsoscelesTriangle
{
    static void Main()
    {
        //Sets the output encoding of the console to Unicode
        //so that it can display the symbol '©'.
        Console.OutputEncoding = Encoding.UTF8;

        //Defines height and width of the output triangle (try 10);
        int size = 5;

        //Specifies the spacing between characters in order to get
        //the triangle using simple formulas.
        Console.WriteLine(new string(' ', (size - 1)) + "©");
        for (int i = 2; i < size; i++)
        {
            Console.WriteLine(new string(' ', (size - i)) + "©" + new string(' ', (2 * i - 3)) + "©");
        }
        for (int i = 1; i <= size; i++)
        {
            Console.Write("©" + new string(' ', 1));
        }
        Console.WriteLine();
    }
}
