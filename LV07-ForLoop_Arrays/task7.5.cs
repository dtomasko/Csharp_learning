/*
Initiate 2 arrays of size 5 with whole numbers. 
The program should print how much elements are in both arrays.
*/

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5] {1,2,3,4,5};
            int[] m = new int[5] {3,4,5,6,7};
            int br = 0;
            for(int i = 0; i < n.Length; i++)
            {
                for(int j = 0; j < m.Length; j++)
                {
                    if (n[i] == m[j]) { cnt++; break;}
                }
            }
            Console.WriteLine(br);

        }
    }
}