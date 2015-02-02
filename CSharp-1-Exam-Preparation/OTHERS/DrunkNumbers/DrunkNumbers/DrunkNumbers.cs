using System;
using System.Numerics;
class DrunkNumbers
{
    static void Main()
    {
        //INPUT
        int rounds = int.Parse(Console.ReadLine());

        //SOLUTION
        int vladko = 0;
        int mitko = 0;
        for (int i = 0; i < rounds; i++)
        {
            string number = Math.Abs(long.Parse(Console.ReadLine())).ToString();
            if (number.Length % 2 == 0)
            {
                for (int k = 0; k < number.Length / 2; k++)
                {
                    mitko += Convert.ToInt32(number[k].ToString());
                    vladko += Convert.ToInt32(number[number.Length - 1 - k].ToString());
                }
            }
            else
            {
                for (int j = 0; j <= number.Length / 2; j++)
                {
                    mitko += Convert.ToInt32(number[j].ToString());
                    vladko += Convert.ToInt32(number[number.Length - 1 - j].ToString());
                }
            }
        }
        //OUTPUT
        if (mitko > vladko)
        {
            Console.WriteLine("M {0}", mitko - vladko);
        }
        else if (vladko > mitko)
        {
            Console.WriteLine("V {0}", vladko - mitko);
        }
        else
        {
            Console.WriteLine("No {0}", vladko + mitko);
        }
    }
}