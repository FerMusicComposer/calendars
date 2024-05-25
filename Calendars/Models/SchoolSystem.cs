namespace Calendars.Models;

public class SchoolSystem(MonthDay cutoffDate, int minAge, MonthDay schoolStartDate)
{
    private readonly MonthDay _cutoffDate = cutoffDate;
    private readonly int _minAge = minAge;
    private readonly MonthDay _schoolStartDate = schoolStartDate;

    public Date GetBeginning(Child child) =>
        child.GetDateByAge(_minAge)
            .GetFirstOccurrence(_cutoffDate)
            .GetFirstOccurrence(_schoolStartDate);
    
}