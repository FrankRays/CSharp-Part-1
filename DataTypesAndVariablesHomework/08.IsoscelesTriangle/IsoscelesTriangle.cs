//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
using System;
using System.Text;
class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int level = 5;
        Console.WriteLine(new string(' ', (level - 1)) + "©");
        for (int i = 2; i < level; i++)
        {
            Console.WriteLine(new string(' ', (level - i)) + "©" + new string(' ', (2 * i - 3)) + "©");
        }
        for (int i = 1; i <= level; i++)
        {
            Console.Write("©" + new string(' ', 1));
        }
        Console.WriteLine();
    }
}
