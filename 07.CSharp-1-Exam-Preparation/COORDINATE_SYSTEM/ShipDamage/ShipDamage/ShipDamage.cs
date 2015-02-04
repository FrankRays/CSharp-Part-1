using System;
class ShipDamage
{
    static void Main()
    {
        //input
        int sX1 = int.Parse(Console.ReadLine());
        int sY1 = int.Parse(Console.ReadLine());
        int sX2 = int.Parse(Console.ReadLine());
        int sY2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int cX1 = int.Parse(Console.ReadLine());
        int cY1 = int.Parse(Console.ReadLine());
        int cX2 = int.Parse(Console.ReadLine());
        int cY2 = int.Parse(Console.ReadLine());
        int cX3 = int.Parse(Console.ReadLine());
        int cY3 = int.Parse(Console.ReadLine());

        //solution
        int damage = 0;

        //damage 100%
        if (Math.Min(sX1, sX2) < cX1 && cX1 < Math.Max(sX1, sX2) && Math.Min(sY1, sY2) < 2*h - cY1 && 2*h - cY1 < Math.Max(sY1, sY2))
        {
            damage += 100;
        }
        if (Math.Min(sX1, sX2) < cX2 && cX2 < Math.Max(sX1, sX2) && Math.Min(sY1, sY2) < 2*h - cY2 && 2*h - cY2 < Math.Max(sY1, sY2))
        {
            damage += 100;
        }
        if (Math.Min(sX1, sX2) < cX3 && cX3 < Math.Max(sX1, sX2) && Math.Min(sY1, sY2) < 2*h - cY3 && 2*h - cY3 < Math.Max(sY1, sY2))
        {
            damage += 100;
        }

        //damage 25%
        if ((cX1 == sX1 || cX1 == sX2) && (2 * h - cY1 == sY1 || 2 * h - cY1 == sY2))
        {
            damage += 25;
        }
        if ((cX2 == sX1 || cX2 == sX2) && (2 * h - cY2 == sY1 || 2 * h - cY2 == sY2))
        {
            damage += 25;
        }
        if ((cX3 == sX1 || cX3 == sX2) && (2 * h - cY3 == sY1 || 2 * h - cY3 == sY2))
        {
            damage += 25;
        }

        //damage 50%
        if ((cX1 == sX1 || cX1 == sX2) && (2 * h - cY1 < Math.Max(sY1, sY2) && 2 * h - cY1 > Math.Min(sY1, sY2)))
        {
            damage += 50;
        }
        if ((cX2 == sX1 || cX2 == sX2) && (2 * h - cY2 < Math.Max(sY1, sY2) && 2 * h - cY2 > Math.Min(sY1, sY2)))
        {
            damage += 50;
        }
        if ((cX3 == sX1 || cX3 == sX2) && (2 * h - cY3 < Math.Max(sY1, sY2) && 2 * h - cY3 > Math.Min(sY1, sY2)))
        {
            damage += 50;
        }
        if ((2 * h - cY1 == sY1 || 2 * h - cY1 == sY2) && (cX1 > Math.Min(sX1, sX2) && cX1 < Math.Max(sX1, sX2)))
        {
            damage += 50;
        }
        if ((2 * h - cY2 == sY1 || 2 * h - cY2 == sY2) && (cX2 > Math.Min(sX1, sX2) && cX2 < Math.Max(sX1, sX2)))
        {
            damage += 50;
        }
        if ((2 * h - cY3 == sY1 || 2 * h - cY3 == sY2) && (cX3 > Math.Min(sX1, sX2) && cX3 < Math.Max(sX1, sX2)))
        {
            damage += 50;
        }

        //output
        Console.WriteLine("{0}%", damage);
    }
}
