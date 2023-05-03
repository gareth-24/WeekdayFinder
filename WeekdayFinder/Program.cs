using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using WeekdayFinder.Models;

namespace WeekdayFinder
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a year:");
      int year = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a month(number):");
      int month = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a day:");
      int day = int.Parse(Console.ReadLine());
      try
      {
        DateTime date = new DateTime(year, month, day);
        Calendar newCalendar = CultureInfo.InvariantCulture.Calendar;
        Console.WriteLine(newCalendar.GetDayOfWeek(date));
      }
      catch(Exception invalidDate)
      {
        Console.WriteLine(invalidDate.Message);
        Console.WriteLine("Please enter a date between 01/01/0001 and 12/31/9999");
      }
      Console.WriteLine("Would you like to check another date? (yes/no)");
      string response = Console.ReadLine();
      if (response == "yes")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye");
      }
    }
  }
}