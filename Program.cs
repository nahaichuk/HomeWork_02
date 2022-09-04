int x = 5;
int y = 20;
double x1, x2, x3, x4;

// -6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15
x1 = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
Console.WriteLine("получилось число x1: " + x1);
// abs(x) * sin(x)
x2 = Math.Abs(x) * Math.Sin(x);
Console.WriteLine("получилось число x2: " + x2);
// 2*pi*x
x3 = 2 * Math.PI * x;
Console.WriteLine("получилось число x3: " + x3);
//max(x, y)
x4 = Math.Max(x, y);
Console.WriteLine("получилось число x4: " + x4);
//Max(x, y);
x4 = Math.Max(x, y);
Console.WriteLine("получилось число x4: " + x4);

DateTime CurrentDate = DateTime.Now;
int DaysPassed = CurrentDate.DayOfYear;
DateTime BeginningYear = CurrentDate.AddDays(-DaysPassed + 1).AddMonths(12);
TimeSpan interval = BeginningYear - CurrentDate;

Console.WriteLine(DaysPassed + " days left to New Year");

Console.WriteLine(interval.Days + " days passed from New Year");
//checked
