/*
Write a program in C# that prints the date of the fifth Tuesday 
of the month, if it exists. Entry of the month
and the year is from the keyboard.
*/


internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("upisi god i mjesec i stavi da je dan 1: ");
        DateTime datum = DateTime.Parse(Console.ReadLine());
        int mjesec=datum.Month;
        int br = 0;
        while (br<5)
        {
            
            if (datum.DayOfWeek == DayOfWeek.Tuesday)
            {
                br++;
                if (br == 5) { Console.WriteLine($"5 utorak je: {datum}"); break; }
            }
            datum = datum.AddDays(1);
            if (datum.Month != mjesec) {  Console.WriteLine("5 utorak ne postoji"); break; }
        }
       
    }}
