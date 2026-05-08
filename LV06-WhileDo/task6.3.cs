

/*
Write a program that loads numbers from the keyboard
as long as their sum is less than 50.
When the sum is > 50 it should stop and print it.
*/

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi broj:");
            int a = int.Parse(Console.ReadLine());
            int zbr = a;
            do
            {
                
                Console.WriteLine("Upisi broj:");
                a = int.Parse(Console.ReadLine());
                zbr += a;
            }
            while (zbr<50);
            Console.WriteLine(zbr);
        }
    }
}