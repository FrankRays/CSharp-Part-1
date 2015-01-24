using System;
class NeuronMapping
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        while (inputLine != "-1")
        {
            uint number = uint.Parse(inputLine);
            char[] binaryNum = Convert.ToString(number, 2)
                .PadLeft(32, '0').ToCharArray();
            bool isInsideNeuron = false;
            bool isOnBoundary = false;
            bool beenInsideNeuron = false;
            for (int i = 0; i < binaryNum.Length; i++)
            {
                if (binaryNum[i] == '1')
                {
                    isOnBoundary = true;
                    if (isInsideNeuron)
                    {
                        isInsideNeuron = false;
                        beenInsideNeuron = true;
                    }
                    binaryNum[i] = '0';
                }
                else
                {
                    if (!beenInsideNeuron && isOnBoundary)
                    {
                        isInsideNeuron = true;
                        isOnBoundary = false;
                    }
                    if (isInsideNeuron)
                    {
                        binaryNum[i] = '1';
                    }
                }
            }
            if (!beenInsideNeuron)
            {
                Console.WriteLine(0);
            }
            else
            {
                ulong result = Convert.ToUInt64(new string(binaryNum), 2);
                Console.WriteLine(result);
            }
            inputLine = Console.ReadLine();

        }
    }
}


