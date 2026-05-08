/*
Write a program in C# that prints the number of seconds until 
the nearest new year (which has passed or which is coming next) 
for the entered date from the keyboard.
*/


internal class program{
private static void Main(string[] args)
    {

        Console.WriteLine("upisi datum");
        DateTime datum=DateTime.Parse(Console.ReadLine());
        int god=datum.Year;
        DateTime a = new DateTime(god + 1, 1, 1);
        DateTime b=new DateTime(god-1, 1, 1);

        TimeSpan datum_nova_god = a - datum;
        TimeSpan datum_star_god = datum - b;

        if (datum_nova_god.TotalSeconds > datum_star_god.TotalSeconds)
        {
            Console.WriteLine($"blize smo staroj god koja je za {datum_star_god.TotalSeconds} sekundi");
        }
        else if(datum_nova_god.TotalSeconds < datum_star_god.TotalSeconds)
        {
            Console.WriteLine($"blize smo novoj god koja je za {datum_nova_god.TotalSeconds} sekundi");
        }
        else Console.WriteLine($"jednako su daleko star i nova god za {datum_nova_god.TotalSeconds} sekundi");
    }
}
