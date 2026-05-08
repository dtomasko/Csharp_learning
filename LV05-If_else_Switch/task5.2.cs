
/*
Load a three-digit number and calculate the sum of its digits.
Then print a message if the sum is even, and if then divide it decimally with 10 
and print the quotient, if not divide the number decimally with 100 and print the quotient.

*/
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("upisi troznam br: ");
            int a=int.Parse(Console.ReadLine());
            int s = a / 100;
            int d=(a % 100)/100;
            int j= a % 10;
            int zbr = s + d + j;
            float kolicnik;
            if (zbr % 2 == 0) { kolicnik = (float)zbr / 10; Console.WriteLine($"{zbr} je paran, kolicnik: {kolicnik}"); }
            else { kolicnik = (float)zbr / 100; Console.WriteLine($"{zbr} je neparan, kolicnik: {kolicnik}"); }
        }
    }
}