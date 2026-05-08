/*
Write a program in C# that will calculate your current number of days of life 
after entering the date of birth.
It uses methods of the DateTime and TimeSpan classes.
Write the days of your life.

*/

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("upisi datu mrodjenja: ");
        DateTime datum = DateTime.Parse(Console.ReadLine());
        DateTime danas=DateTime.Now;
        TimeSpan brdana = danas - datum;

        Console.WriteLine($"broj dana zivota:{brdana.Days}");



    }
}