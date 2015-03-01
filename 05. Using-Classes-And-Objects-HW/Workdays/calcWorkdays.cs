//Problem 5. Workdays

//    Write a method that calculates the number of workdays between today and given date, passed as parameter.
//    Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.


using System;

class calcWorkdays
{
    static void Main()
    {
        DateTime dateNow = DateTime.Now;
        Console.Write("Enter day in format Year.Month.Day: ");
        string[] dateStr = Console.ReadLine().Split('.');
        int year = int.Parse(dateStr[0]);
        int month = int.Parse(dateStr[1]);
        int days = int.Parse(dateStr[2]);
        
        DateTime endDate = new DateTime(year, month, days);
        Console.WriteLine("There are {0} working days between {1} and {2}", WorkingDays(dateNow, endDate), dateNow.ToShortDateString(), endDate.ToShortDateString());
    }

    static DateTime[] Holidays = {
                                    new DateTime(2014,01,08),
                                    new DateTime(2014,01,08),
                                    new DateTime(2014,01,18),
                                    new DateTime(2014,01,22),
                                    new DateTime(2014,01,23),
                                  };
    static int WorkingDays(DateTime dateNow, DateTime dateInFuture)
    {
        int daysLenght = Math.Abs((dateNow - dateInFuture).Days);
        int counter = daysLenght;
        if (dateNow > dateInFuture)
        {
            dateNow = dateInFuture;
            dateInFuture = DateTime.Now;
        }
        for (int i = 0; i < daysLenght; i++)
        {
            dateNow = dateNow.AddDays(1);
            if (dateNow.DayOfWeek == DayOfWeek.Sunday || dateNow.DayOfWeek == DayOfWeek.Saturday)
            {
                counter--;
            }
            for (int days = 0; days < Holidays.Length; days++)
            {
                if (dateNow.CompareTo(Holidays[days]) == 0)
                {
                    counter--;
                }
            }
        }
        return counter;
    }
}

