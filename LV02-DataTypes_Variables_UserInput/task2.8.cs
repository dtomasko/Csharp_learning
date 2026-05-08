
/*
Temperature conversion
Write a program that asks users to enter the temperature in degrees
Celsius (float).The program then converts that temperature to Fahrenheite (double) 
and formats printing. Show with three decimal places for Fahrenheit and two decimal places for Celsius.

*/
internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Upisi temp u  celz: ");
        float a=float.Parse(Console.ReadLine());
        double b = (a * 9 / 5) + 32;
        Console.WriteLine($"fahrenhite: {b:F3}°F, celzijus: {a:F2}°C");


    }
}