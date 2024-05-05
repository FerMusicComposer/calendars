namespace Calendars.Models;

public class SchoolSystem(MonthDay cuttoffDate, int minAge, MonthDay schoolStartDate)
{
    private readonly MonthDay _cuttoffDate = cuttoffDate;
    private readonly int _minAge = minAge;
    private readonly MonthDay _schoolStartDate = schoolStartDate;
    
}