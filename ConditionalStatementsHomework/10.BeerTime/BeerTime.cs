//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
//a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time 
//according to the definition above or invalid time if the time cannot be parsed. 
//Note: You may need to learn how to parse dates and times.

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
