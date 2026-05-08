
//Write a program in C# that determines whether the entered year is a leap year

internal class Program
    {
        static void Main(string[] args)
        {
            DateTime datum = DateTime.Parse(Console.ReadLine());
            int god = datum.Year;
            if((god%4==0 && god % 100 != 0) || god%400==0)
            {
                Console.WriteLine("Godina je prijestupna!");
            }
            else
            {
                Console.WriteLine("Godina nije prijestupna!");
            }
        }
    }