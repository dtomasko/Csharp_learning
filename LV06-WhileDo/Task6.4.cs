
//Write a program that loads the numbers from the keyboard with until zero is typed.
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("upisi broj: ");
        int a=int.Parse(Console.ReadLine());
        do
        {
       Console.WriteLine("upisi broj: ");
       a=int.Parse(Console.ReadLine());


        } while(a!=0);


    }



}