var myDaysOff = Weekdays.Monday | Weekdays.Tuesday;

Console.WriteLine($"My Days Off Include Monday: {myDaysOff.HasFlag(Weekdays.Monday)}"); //true
Console.WriteLine($"My Days Off Include Tuesday: {myDaysOff.HasFlag(Weekdays.Tuesday)}"); //true

var myWorkDays = Weekdays.All ^ myDaysOff;
Console.WriteLine($"My Workdays: {myWorkDays}"); //Wednesday, Thursday, Friday, Weekend


[Flags]
public enum Weekdays
{
    None = 0,
    Monday = 1 << 0,
    Tuesday = 1 << 1,
    Wednesday = 1 << 2,
    Thursday = 1 << 3,
    Friday = 1 << 4,
    Saturday = 1 << 5,
    Sunday = 1 << 6,
    Workdays = Monday | Tuesday | Wednesday | Thursday | Friday, 
    Weekend = Saturday | Sunday,
    All = Workdays | Weekend
}