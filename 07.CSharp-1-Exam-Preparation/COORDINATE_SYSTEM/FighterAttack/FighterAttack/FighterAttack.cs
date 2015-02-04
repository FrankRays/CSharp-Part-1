using System;
class FighterAttack
{
    static bool isInsideField(int cX1, int cY1, int sX1, int sY1, int sX2, int sY2)
    {
        if (Math.Min(sX1, sX2) <= cX1 && cX1 <= Math.Max(sX1, sX2) && Math.Min(sY1, sY2) <= cY1 && cY1 <= Math.Max(sY1, sY2))
        {
            return true;
        }
        else return false;
    }
    static void Main()
    {
        //input
        int fX1 = int.Parse(Console.ReadLine());
        int fY1 = int.Parse(Console.ReadLine());
        int fX2 = int.Parse(Console.ReadLine());
        int fY2 = int.Parse(Console.ReadLine());
        int pX = int.Parse(Console.ReadLine());
        int pY = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        //solution
        int damage = 0;
        int targetX = pX + d;
        int targetY = pY;
        int frontX = targetX + 1;
        int frontY = targetY;
        int upX = targetX;
        int upY = targetY + 1;
        int downX = targetX;
        int downY = targetY - 1;

        if(isInsideField(targetX,targetY,fX1,fY1,fX2,fY2))
        {
            damage += 100;
        }
        if (isInsideField(frontX, frontY, fX1, fY1, fX2, fY2))
        {
            damage += 75;
        }
        if (isInsideField(upX, upY, fX1, fY1, fX2, fY2))
        {
            damage += 50;
        }
        if (isInsideField(downX, downY, fX1, fY1, fX2, fY2))
        {
            damage += 50;
        }

        //output
        Console.WriteLine("{0}%",damage);
    }
}
