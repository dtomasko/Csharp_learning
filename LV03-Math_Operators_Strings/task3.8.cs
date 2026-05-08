
/*
Is the year leap.
Write a program that checks whether the year entered is 
a leap year.Use operators. The year is leap if it is
divisible by 4, but not with 100, except if its divisible by 400.
The program should request an entry of the year and then print a message as to whether the year is leap or not

*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("upisi godinu: ");
        int a = int.Parse(Console.ReadLine());
        if ((a % 4 == 0) && (a % 100 != 0) || (a % 400 == 0)) Console.WriteLine("god je prijestupna");
        else Console.WriteLine("nije");
       
    }
}
