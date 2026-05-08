 
 /*
Declare a series of 3 integers, 
upload them and using tab print members of that string, 
the print the integer hut of those number divided by 3
and bellow that float huts.
EXAMPLE:
2 3 7
0 1 2
0.666666 1,000000 2,333333
 */
 internal class Program{
 static void Main(string[] args)
    {

        int[] a = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("UPISI 3 BR:");
            a[i] = int.Parse(Console.ReadLine());

        }
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{a[i]}\t");
        }
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{a[i] / 3}\t");
        }
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{((float)a[i] / 3):F2}\t");

        }
    }
}
