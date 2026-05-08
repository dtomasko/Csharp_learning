

/*
Maximum of three numbers
Write a program that asks users to enter three numbers.
Using a operators, find  the largest of the three numbers entered.
 */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("upisi 1. broj: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("upisi 2. broj: ");
        int b= int.Parse(Console.ReadLine());

        Console.WriteLine("upisi 3. broj: ");
        int c = int.Parse(Console.ReadLine());
        int max = a;
        if(b > max)max= b;
        if(c > max)max= c;
        Console.WriteLine(max);
    }
}