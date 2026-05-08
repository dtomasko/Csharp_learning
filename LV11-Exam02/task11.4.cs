/*
Write a program in C# that prints the name of the day
before the last day of the month.Entry of the month is from the keyboard.
Watch out for leap years.

*/
internal class program{
    private static void Main(string[] args)
    {
        Console.WriteLine("upisi god: ");
        int god= int.Parse(Console.ReadLine());
        Console.WriteLine("upisi mjesec");
        int mjesec=int.Parse(Console.ReadLine());
        int br_dana=DateTime.DaysInMonth(god,mjesec);
        int predzadnji_dan=br_dana-1;

        DateTime datum=new DateTime(god,mjesec,predzadnji_dan);
        Console.WriteLine($"prezadnji dan u mjesecu je {datum.DayOfWeek}");

    }
}