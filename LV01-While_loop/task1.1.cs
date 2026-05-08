
//Task 1: Write a program that prints your name 5 times
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Upisi svoje ime: ");
        string ime=Console.ReadLine();
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(ime);
            i++;
        }
    }
}