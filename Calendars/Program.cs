// See https://aka.ms/new-console-template for more information

using Calendars.Models;

static void Demonstrate(Calendar calendar)
{
    SchoolSystem schoolSystem = new(calendar.Create(3, 1), 5, calendar.Create(8, 5));
    Child child = new("Jane", calendar.Create(1892, 2, 29));
    Child child2 = new("Jake", calendar.Create(1891, 8, 27));

    Console.WriteLine($"Using {calendar.GetName()} calendar:");
    Report(child, schoolSystem);
    Report(child2, schoolSystem);
    Console.WriteLine();
}

static void Report(Child child, SchoolSystem school)
{
    Console.WriteLine($"{child} starts school on {school.GetBeginning(child)}. Celebrates 1st birthday at school on {child.GetFirstCelebrationAt(school)}");    
}

// Liskov Substitution Principle
Calendar julian = new JulianCalendar(); 
Calendar gregorian = new GregorianCalendar();

Demonstrate(julian);
Demonstrate(gregorian);
