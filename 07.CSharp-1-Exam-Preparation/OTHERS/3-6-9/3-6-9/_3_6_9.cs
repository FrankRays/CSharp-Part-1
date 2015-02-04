using System;
class _3_6_9
{
    static void Main()
    {
        //INPUT
        long fnumber = long.Parse(Console.ReadLine());
        long snumber = long.Parse(Console.ReadLine());
        long tnumber = long.Parse(Console.ReadLine());

        //SOLUTION
        long result = 0;
        switch (snumber)
        {
            case 3: result = fnumber + tnumber; break;
            case 6: result = fnumber * tnumber; break;
            case 9: result = fnumber % tnumber; break;
        }

        //OUTPUT
        if (result % 3 == 0)
        {
            Console.WriteLine(result / 3);
        }
        else
        {
            Console.WriteLine(result % 3);
        }

        Console.WriteLine(result);
    }
}