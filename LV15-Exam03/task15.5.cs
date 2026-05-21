

/*
Write a program in C# that will calculate your current age after entering your birthdate. Use the methods of the DateTime and TimeSpan classes. Print the years.

*/

internal class Program
    {
        static void Main(string[] args)
        {


        Console.WriteLine("upisi datum rodnjenja: ");
        DateTime datum= DateTime.Parse(Console.ReadLine());


        int god = DateTime.Now.Year - datum.Year;
        if (DateTime.Now.Month < datum.Month) god--;
        Console.WriteLine(god);

        /*
        OR
         
        Console.WriteLine("upisi datum rodnjenja: ");
        DateTime datum= DateTime.Parse(Console.ReadLine());


        TimeSpan a = DateTime.Now - datum;

        int god=a.Days / 365;
        Console.WriteLine($"stari ste {god}");


         
         */
    }
}