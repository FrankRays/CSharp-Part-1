using System;
using System.Globalization;
class NextDate
{
    static void Main()
    {
        //INPUT
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        DateTime today = new DateTime(year, month, day);

        //SOLUTION
        DateTime tomorrow = today.AddDays(1);

        //OUTPUT
        Console.WriteLine(Convert.ToDateTime(tomorrow.ToString()).ToString("d.M.yyyy"));
    }
}
