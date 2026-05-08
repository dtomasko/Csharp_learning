

/*
Declare a float type variable and load two numbers, 
the first represents the initial temperature, and the second represents 
the final temperature in degrees Celsius. Based on these
temperature, calculate the difference between them.
If the difference is less than 5, print the message "Almost the same temperature. 
If the difference is between 5 and 20, print the message "Significant change".
If it is difference greater than 20, print the message "Great Change". 
Also, print a message if it is the temperature was initially above 30°C or if the final temperature was below 0°C.
*/

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k = Convert.ToDouble(Console.ReadLine()),
                c = Convert.ToDouble(Console.ReadLine());
            double f = (c + 273)- k;
            if (f < 5) Console.WriteLine("Gotovo ista temperatura");
            if (f>5 && f<20)Console.WriteLine("Znacajna promjena");
            if (f > 20) Console.WriteLine("Velika promjena");
            if (k - 273 > 30) Console.WriteLine("Pocetna temperatura je iznad 30°C");
            if (c < 0) Console.WriteLine("Krajnja temperatura je ispod 0°C");

        }

    }
}