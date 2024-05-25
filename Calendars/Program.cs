// See https://aka.ms/new-console-template for more information

using Calendars.Models;

// Liskov Substitution Principle
List<Calendar> calendars = [new JulianCalendar(), new GregorianCalendar()];

foreach (Calendar calendar in calendars)
{
    Demonstrate(calendar);
}
return;

static void Report(List<Child> children, SchoolSystem school)
{
    foreach (Child child in children)
    {
        Console.WriteLine($"{child} starts school on {school.GetBeginning(child)}. Celebrates 1st birthday at school on {child.GetFirstCelebrationAt(school)}");
    }    
}

static void Demonstrate(Calendar calendar)
{
    SchoolSystem schoolSystem = new(calendar.Create(3, 1), 5, calendar.Create(8, 5));
    List<Child> children =
    [
        new Child("John", calendar.Create(1891, 1, 1)),
        new Child("Jane", calendar.Create(1892, 2, 29)),
        new Child("Jake", calendar.Create(1891, 8, 27)),
        new Child("Jill", calendar.Create(1892, 3, 7)),
        new Child("Josh", calendar.Create(1892, 5, 1)),
        new Child("Jess", calendar.Create(1891, 11, 3)),
        new Child("Jose", calendar.Create(1890, 7, 13)),
        new Child("Jessica", calendar.Create(1890, 12, 25))
    ];
    
    Console.WriteLine($"Using {calendar.GetName()} calendar:");
    Report(children, schoolSystem);
    Console.WriteLine();
}

  