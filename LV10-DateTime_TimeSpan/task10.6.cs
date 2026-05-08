  /*
Write a program in C# to display various time data
a) Current date and time
b) Current year
c) Month of the year
d) Number of weeks in the year
e) Day of the week
f) Day of the year
g) Day of the month
h) Name of the day of the week
Apply the appropriate methods and properties if they exist
  
  */
  
  internal class Program
    {
        static void Main(string[] args)
        {
            DateTime pocGod = new DateTime(2026, 1, 1, 0, 0, 0);
            TimeSpan raz = DateTime.Now - pocGod;
            Console.WriteLine("Trenutni datum i vrijeme: {0}", DateTime.Now);
            Console.WriteLine("Tekuca godina: {0}", DateTime.Now.Year);
            Console.WriteLine("Mjesec u godini: {0}", DateTime.Now.Month);
            Console.WriteLine("Broj tjedna u godini: {0}", (int)raz.TotalDays/7);
            Console.WriteLine("Dan u tjednu: {0}", (int)DateTime.Now.DayOfWeek);
            Console.WriteLine("Dan u godini: {0}", (int)raz.Days);
            Console.WriteLine("Dan u mjesecu: {0}", DateTime.Now.Day);
            Console.WriteLine("Dan u tjednu: {0}", DateTime.Now.DayOfWeek);
        }
    }