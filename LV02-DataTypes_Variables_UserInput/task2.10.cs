
/*
A km to miles conversion and km to feet
Write a program that allows the user to enter distances in km (decimal) 
and then convert the value to miles (double) and feet (int). 
Format the output so that km is with 1 decimal place,
miles with 2 decimals and feet int.
*/

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Unesite udaljenost u kilometrima:");
        decimal km = decimal.Parse(Console.ReadLine());

        double milje = (double)(km * (decimal)0.621371);
        int stope = (int)(km*(decimal)3280.8399);
        Console.WriteLine($"km: {km:F1}km, milje: {milje:F2}mi,stope {(int)stope}ft");
    }
}
