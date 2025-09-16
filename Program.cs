/* 01. Student Information
string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
double averageGrade = double.Parse(Console.ReadLine());
Console.WriteLine($"Name: {name}, Age: {age}, Grade: {averageGrade:f2}");
*/
/*02. Passed
double grade = double.Parse(Console.ReadLine());
if (grade >= 3.00)
{ 
    Console.WriteLine("Passed!");
}    
*/
/*03. Passed or Failed
double grade = double.Parse(Console.ReadLine());
if (grade >= 3.00)
{
    Console.WriteLine("Passed!");
}
else
{
    Console.WriteLine("Failed!");
}
*/
/*04. Back in 30 Minutes
int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
minutes += 30;
if (minutes > 59)
{
    hour++;
    minutes -= 60;
}
if (hour > 23)
{
    hour = 0;
}
Console.WriteLine($"{hour}:{minutes:d2}");
*/
/*05. Month Printer
int month = int.Parse(Console.ReadLine());
switch (month)
{
    case 1: Console.WriteLine("January"); break;
    case 2: Console.WriteLine("February"); break;
    case 3: Console.WriteLine("March"); break;
    case 4: Console.WriteLine("April"); break;
    case 5: Console.WriteLine("May"); break;
    case 6: Console.WriteLine("June"); break;
    case 7: Console.WriteLine("July"); break;
    case 8: Console.WriteLine("August"); break;
    case 9: Console.WriteLine("September"); break;
    case 10: Console.WriteLine("October"); break;
    case 11: Console.WriteLine("November"); break;
    case 12: Console.WriteLine("December"); break;
    default: Console.WriteLine("Error!"); break;
}
*/
/*06. Foreign Languages
string country = Console.ReadLine();
switch (country)
{
    case "England":
    case "USA": Console.WriteLine("English");break;
    case "Spain":
    case "Argentina":
    case "Mexico": Console.WriteLine("Spanish");break;
    default: Console.WriteLine("unknown");break;
}
*/
/*07. Theatre Promotions
string day = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
switch (day)
{
    case "Weekday":
        if (age >= 0 && age <= 18)
        {
            Console.WriteLine("12$");
        }
        else if (age > 18 && age <= 64)
        {
            Console.WriteLine("18$");
        }
        else if (age > 64 && age <= 122)
        {
            Console.WriteLine("12$");
        }
        else
        { Console.WriteLine("Error!"); }
        break;
    case "Weekend":
        if (age >= 0 && age <= 18)
        {
            Console.WriteLine("15$");
        }
        else if (age > 18 && age <= 64)
        {
            Console.WriteLine("20$");
        }
        else if (age > 64 && age <= 122)
        {
            Console.WriteLine("15$");
        }
        else
        { Console.WriteLine("Error!"); }
        break;
    case "Holiday":
        if (age >= 0 && age <= 18)
        {
            Console.WriteLine("5$");
        }
        else if (age > 18 && age <= 64)
        {
            Console.WriteLine("12$");
        }
        else if (age > 64 && age <= 122)
        {
            Console.WriteLine("10$");
        }
        else
        { Console.WriteLine("Error!"); }
        break;
    default: Console.WriteLine("Error!"); break;
}
*/
/*08. Divisible by 3
for (int i = 3; i <= 100; i+=3)
{
    Console.WriteLine(i);
}
*/
/*09. Sum of Odd Numbers
int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= 2 * n; i += 2)
{
    Console.WriteLine(i);
    sum += i;
}

Console.WriteLine($"Sum: {sum}");
*/
/*10. Multiplication Table
int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    int result = num * i;
    Console.WriteLine($"{num} X {i} = {result}");
}
*/
/*11. Multiplication Table 2.0
int num = int.Parse(Console.ReadLine());
int multiplier = int.Parse(Console.ReadLine());
if (multiplier <= 10)
{
    for (int i = multiplier; i <= 10; i++)
    {
        int result = num * i;
        Console.WriteLine($"{num} X {i} = {result}");
    }
}
else
{
        int result = num * multiplier;
        Console.WriteLine($"{num} X {multiplier} = {result}");
}
*/
/*12. Even Number
while (true)
{ 
    int num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.WriteLine($"The number is: {Math.Abs(num)}");
        break;
    }
    else
    {
        Console.WriteLine("Please write an even number.");
    }
}
*/
/*13. Holidays Between Two Dates
using System;
using System.Globalization;
class HolidaysBetweenTwoDates
{ 
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        if (startDate > endDate)
        {
            Console.WriteLine(0);
            return;
        }
        int holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        }
        Console.WriteLine(holidaysCount);
    }
}
*/

