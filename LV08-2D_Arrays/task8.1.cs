/*
Initialize a 2D array of size 3x5 (3 rows, 5 columns) 
with integers, and print what percentage of numbers in each row 
is smaller than the average of the entire 2D array.
*/

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { {1,2,3,4,5},{6,7,8,9,10},{11,12,13,14,15} };
            double z = 0, Sr;
            int br = 0;
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    z+= a[i,j];
                }
            }
            Sr = z / 15;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < Sr) br++;
                }
                Console.WriteLine("{0}. red: {1}%", i + 1,(double)br/5*100);
                br= 0;
            }
            Console.WriteLine(Sr);
        }
    }
}