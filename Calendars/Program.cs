// See https://aka.ms/new-console-template for more information

using Calendars.Models;

Date birthDate = new(2016, new MonthDay(2, 29));
Child child = new("Jane", birthDate);

Console.WriteLine(birthDate);
Console.WriteLine(child);