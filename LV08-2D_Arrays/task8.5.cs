/*

Load a four-digit number and create a 2d array with 4 rows and 4 columns.
The digits of the number go in order in the first row,
and each subsequent row contains three times larger numbers than in the previous row.
Print that tabular field.

EXAMPLE:
Number 3567 has been loaded.
should print:
3 5 6 7
9 15 18 21
27 45 54 63

*/

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            int br = int.Parse(Console.ReadLine());
            a[0, 0] = br / 1000;
            a[0, 1] = br % 1000 / 100;
            a[0, 2] = br % 100 / 10;
            a[0, 3] = br % 10;
            for(int i = 0; i < 4; i++)
            {
                Console.Write("{0} ",a[0, i]);
            }
            Console.WriteLine();
            for(int i = 1;i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    a[i, j] = a[i - 1, j] * 3;
                    Console.Write("{0} ", a[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}