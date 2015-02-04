using System;
class A_nacci
{
    static void Main()
    {
        //INPUT
        long firstMember = long.Parse((Console.ReadLine()[0] - 'A' + 1).ToString());
        long secondMember = long.Parse((Console.ReadLine()[0] - 'A' + 1).ToString());
        long indexN = long.Parse(Console.ReadLine());

        long helper = 0;
        Console.WriteLine((char)(firstMember + 'A' - 1));
        if (indexN > 1)
        {
            Console.WriteLine("{0}{1}", (char)(secondMember%27 + 'A' - 1), (char)((firstMember + secondMember)%27 + 'A' - 1));
            helper = firstMember + secondMember;
            secondMember += firstMember;
            firstMember = secondMember - firstMember;
            secondMember = helper;
        }
        for (int i = 2; i < indexN; i++)
        {
            for (int j = 0; j <= 1; j++)
            {
                helper = firstMember + secondMember;
                secondMember += firstMember;
                firstMember = secondMember - firstMember;
                secondMember = helper;
                if (secondMember%26 == 0)
                {
                    Console.Write((char)(25 + 'A' - 1));
                }
                Console.Write((char)(secondMember%26 + 'A' - 1));
                for (int k = 0; k <= i - 2; k++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}