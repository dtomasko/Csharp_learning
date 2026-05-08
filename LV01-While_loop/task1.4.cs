

//Task 4: Write a program that loads the numbers from the keyboard as long as their sum is less than 50.
//When equal to or greater than 50, it should be printed as much as that sum is and stopped by input.
internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("upisi br: ");
        int i=int.Parse(Console.ReadLine());
        int zbr = 0;
        while (true)
        {
            zbr = zbr + i;
            if (zbr >=50) break;
            else
            {
               
                Console.WriteLine("upisi br: ");
                i = int.Parse(Console.ReadLine());
                
            }
        }
        Console.WriteLine(zbr);
    }
}