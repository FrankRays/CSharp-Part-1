using System;
class Sheets
{
    static void Main()
    {

        //INPUT
        string number = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(11, '0');

        //OUTPUT
        for (int i = 0; i < number.Length; i++)
        {
            if (number[number.Length - 1 - i] == '0')
            {
                Console.WriteLine("A{0}", number.Length - 1 - i);
            }
        }
    }
}