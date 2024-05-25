namespace Calendars.Models;

public class JulianCalendar : Calendar
{
    public override bool IsLeap(int year) =>
        year % 4 == 0;

    public override string GetName() =>
        "Julian";
}