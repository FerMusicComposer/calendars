namespace Calendars.Models;

public abstract class Calendar
{
    public Date Create(int year, int month, int day) =>
        new Date(this, year, new MonthDay(this, month, day));

    public MonthDay Create(int month, int day) =>
        new MonthDay(this, month, day);

    public abstract bool IsLeap(int year);

    public virtual bool IsLeapDay(int month, int day) =>
        month == 2 && day == 29;

    public virtual int NextMonth(int aftermonth) =>
        aftermonth % 12 + 1;

    public virtual int MaxDaysInMonth(int month) =>
        month switch
        {
            2 => 29,
            4 or 6 or 9 or 11 => 30,
            _ => 31
        };

    public abstract string GetName();
}