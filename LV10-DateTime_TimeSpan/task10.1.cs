  
  /*
Write a program that loads the date of birth,
and prints the day, month and year separately.
Also write the date of the 18th birthday.
  
  */
  
  internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("upsii datum rodjenja: ");
            DateTime datum = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"godine: {datum.Year}");
            Console.WriteLine($"mjesec: {datum.Month}");
            Console.WriteLine($"dani: {datum.Day}");


            DateTime rodjendan = datum.AddYears(18);
            Console.WriteLine($"18. rodjendan je datuma: {rodjendan}");
        }
    }