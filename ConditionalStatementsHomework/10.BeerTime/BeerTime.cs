//
using System;
class BeerTime
{
    static void Main()
    {
        DateTime userTime;
        bool isDateTime = DateTime.TryParse(Console.ReadLine(), out userTime);
        if (isDateTime == true)
        {
            if ((userTime.Hour >= 13 && userTime.Hour <= 24) || (userTime.Hour < 3 && userTime.Hour >= 0))
            {
                Console.WriteLine("BEER TIME");
            }
            else
            {
                Console.WriteLine("NON-BEER TIME");
            }
        }
        else Console.WriteLine("Invalid input.");
    }
}
