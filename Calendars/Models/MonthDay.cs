namespace Calendars.Models;

public class MonthDay(Calendar calendar, int month, int day)
{
    private readonly int _month = month;
    private readonly int _day = day;
    private readonly Calendar _calendar = calendar;
    
    public bool IsLeap() => 
        _calendar.IsLeapDay(_month, _day);
    
    public MonthDay GetNextDay() =>
        IsEndOfMonth() ? _calendar.Create(_calendar.NextMonth(_month), 1)
        : _calendar.Create(_month, _day + 1);
    
    private bool IsEndOfMonth() => 
        _day == _calendar.MaxDaysInMonth(_month);
    
    private int DaysInMonth() =>
        _month switch
        {
            2 => 29,
            4 or 6 or 9 or 11 => 30,
            _ => 31
        };

    private int NextMonth() => _month % 12 + 1;
    
    public bool IsBefore(MonthDay other) => 
        _month < other._month ||
        (_month == other._month && _day < other._day);

    public override string ToString() => $"{_day}/{_month}";
}