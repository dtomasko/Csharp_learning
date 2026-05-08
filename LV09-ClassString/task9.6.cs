
/*
Write a program that will ask the user to enter three strings, 
and then sort them in alphabetical order and print them.

*/

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[3];
            for (int i = 0; i < 3; i++)
            {
                a[i] = Console.ReadLine();
            }
            Array.Sort(a);
            for (int i = 0;i < 3;i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, a[i]);
            }
        }
    }
}