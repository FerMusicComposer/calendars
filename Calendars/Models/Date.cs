namespace Calendars.Models;

public class Date(Calendar calendar,int year, MonthDay monthDay)
{
    private readonly int _year = year;
    private readonly MonthDay _monthDay = monthDay; // Single Responsibility Principle
    private readonly Calendar _calendar = calendar;

    public Date AddYears(int count) => FirstValidDate(_year + count, _monthDay);

    private Date FirstValidDate(int year, MonthDay day) =>
        new Date( _calendar, year, day.IsLeap() && !_calendar.IsLeap(year) ? day.GetNextDay() : day);

    private Date GetFirstDayOccurrence(int year, MonthDay day) => 
        new Date(_calendar ,day.IsLeap() ? GetLeap(year) : year, day);
    public Date GetFirstDayOccurrence(Date day) => 
        GetFirstDayOccurrence(_year, day._monthDay);
    
    public Date GetFirstOccurrence(MonthDay day) =>
        GetFirstDayOccurrence(day.IsBefore(_monthDay) ? _year + 1 : _year, day);
    private int GetLeap(int year) => 
        _calendar.IsLeap(year) ? year : GetLeap(year + 1);
    public override string ToString() => $"{_monthDay}/{_year:0000}";
}