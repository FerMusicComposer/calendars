namespace Calendars.Models;

public class Child(string name, Date birthDate)
{
    private readonly string _name = name;
    private readonly Date _birthDate = birthDate;

    public override string ToString()
    {
        return $"{_name} was born on {_birthDate}";
    }
}