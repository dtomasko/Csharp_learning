/*
Initialize an integer 2D array of size 3x5, 
load the first two rows from the keyboard.
The third row consists of numbers that are the sum of each individual column above it.
For example:3, 6, 1, -9, 3
            1, 0, -2, 4, 2
            4, 6, -1, -5, 5

*/

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 5];
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0;i < 5; i++)
            {
                a[2, i] = a[0, i] + a[1, i];
            }
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0;j < 5; j++)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}