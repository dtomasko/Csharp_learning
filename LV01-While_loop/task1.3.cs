
//Task 3: Write a program that loads the numbers from the keyboard until 0 is typed.
internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("upisi br: ");
        int i=int.Parse(Console.ReadLine());
        while (i!=0)
        {
            Console.WriteLine(i);
            i = int.Parse(Console.ReadLine());
           
           
        }
    }
}
