
/*Task 1: Entry and printing of multiple numbers (while the user does not enter a negative number)
Write a program that asks the user to enter the numbers. The number entry is interrupted by a negative number. 
Finally, the program prints all numbers except negative.*/
internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("upisi br: ");
        int i=int.Parse(Console.ReadLine());
        int[] a = new int[100];
        int j = 0;
        while (i>0)
        {
            a[j] = i;
            j++;
                Console.WriteLine("upisi br: ");
                i = int.Parse(Console.ReadLine());
                
            
        }
        Console.WriteLine("uneseni brojevi:");
        for(int k = 0; k < j; k++)
        {
            Console.WriteLine(a[k]);
        }
        
    }
}
