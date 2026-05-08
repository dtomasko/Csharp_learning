
/*
Time conversion.
Write a program that asks users to enter the number of seconds.
Using operators, convert the total number of seconds to hours, minutes, and leftover seconds.
For example, 3661 seconds should be displayed as 1 hour, 1 minute and 1 second.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("upisi sekunde: ");
        int a = int.Parse(Console.ReadLine());
        int h = (int)a / 3600;
        int ostatak1 = a - (h * 3600);
        int min = (int)ostatak1 / 60;
        int ostatk2=ostatak1 - (min * 60);
        Console.WriteLine($"sati: {h}, minute; {min}, sec: {ostatk2}");
       
    }
}