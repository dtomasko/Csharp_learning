
//Write a program that prints numbers from 5 to 0, one below the other

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi broj(0 za prekid):");
            int a = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(a);
                Console.WriteLine("Upisi broj(0 za prekid):");
                a = int.Parse(Console.ReadLine());
            }
            while (a != 0);
        }
    }
}