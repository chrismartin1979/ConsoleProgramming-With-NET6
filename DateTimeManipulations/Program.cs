// See https://aka.ms/new-console-template for more information
using System.Globalization;

// Empty DateTime
DateTime date = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1979, 05, 20);
Console.WriteLine("My DOB is: " + dateOfBirth);
Console.WriteLine("My DOB (only date) is: " + dateOfBirth.Date);

Console.WriteLine("Day of Week:{0}", dateOfBirth.DayOfWeek);
Console.WriteLine("Day of Year:{0}", dateOfBirth.DayOfYear);
Console.WriteLine("Time of Day:{0}", dateOfBirth.TimeOfDay);
Console.WriteLine("Ticks:{0}", dateOfBirth.Ticks);  // Number of ticks in time (like on a clock)
Console.WriteLine("Kind:{0}", dateOfBirth.Kind);   // What Time Zone is it in (unspecified means that no time zone was given

// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The Time Now is: " + now);

// Create a DateTime from a String
DateTime datefromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine("The Date from string is: " + datefromString);

// Add Additional Time
Console.WriteLine("One Hour from now is: " + now.AddHours(1));
Console.WriteLine("One Day from now is: " + now.AddDays(1));

// Ticks from DateTime
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date Only: " + dateOnlyOfBirth);

// Time Only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine("Time Only: " + timeOnly);