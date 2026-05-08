

/*
Write a program that asks users to enter a int number
and then use an operator to check whether the number is even or odd.
If the number is even, print "The number is even",
If the number is odd print "The number is odd".
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("upisi broj: ");
        int a=int.Parse(Console.ReadLine());
        if (a % 2 == 0) Console.WriteLine("paran");
        else Console.WriteLine("nepar");
    }
}