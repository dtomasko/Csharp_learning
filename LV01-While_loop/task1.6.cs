
/*Task 2: Counting of even and odd numbers.
Write a program that asks users to enter 10 numbers. 
Count how many of the numbers entered are even, and how much odd.*/

internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;
        int par = 0;
        int nepar = 0;

        while (i < 10)
        {
            i++;
            Console.WriteLine($"upisi {i}. broj: ");
           
            int a=int.Parse(Console.ReadLine());
            if (a % 2 == 0) par++;
            if(a % 2 !=0)nepar++;



        }
        Console.WriteLine($"PARNI: {par} Neparni:{nepar}");
    }
}
