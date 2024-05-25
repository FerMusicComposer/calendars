namespace Calendars.Models;

public class Child(string name, Date birthDate)
{
    private readonly string _name = name;
    private readonly Date _birthDate = birthDate;

    public Date GetDateByAge(int minAge)=> _birthDate.AddYears(minAge);
    public Date GetFirstCelebrationAt(SchoolSystem school) => 
        school.GetBeginning(this).GetFirstDayOccurrence(_birthDate);
    
    public override string ToString() => $"{_name} born on {_birthDate}";

}