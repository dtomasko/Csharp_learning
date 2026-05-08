
/*Task 3: Guessing number.
Write a program that generates a random number between 1 and 100
and then the user guesses. The program provides feedback on whether the number entered is less than or greater than the requested count.
The program ends when the user hits the number.
*/
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = RandomNumberGenerator.GetInt32(1, 100);
        Console.WriteLine(a);
        Console.WriteLine("Upisi broj: ");
        int i=int.Parse(Console.ReadLine());
       
        while (a != i) {


         if (a > i) Console.WriteLine("broj je veci od upisanog.");
            else if (a < i) Console.WriteLine("broj je manji od upisanog.");
            Console.WriteLine("Upisi broj: ");
         i = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("pogodili ste.");
    }
}