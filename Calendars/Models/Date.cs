namespace Calendars.Models;

public class Date(int year, MonthDay monthDay)
{
    private readonly int _year = year;
    private readonly MonthDay _monthDay = monthDay; // Single Responsibility Principle!!!

    public override string ToString()
    {
        return $"{_monthDay}/{_year:0000}";
    }
}