namespace Calendars.Models;

public class MonthDay(int month, int day)
{
    private readonly int _month = month;
    private readonly int _day = day;

    public override string ToString()
    {
        return $"{_day}/{_month}";
    }
}