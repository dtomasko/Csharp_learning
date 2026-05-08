
/*
Number guessing game
Write down a program that simulates a game of guessing a number. 
The user should guess a randomized number between 1 and 100.
The program will say if the random number is smaller or bigger
than the input after each attempt. 
*/

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            Console.WriteLine(trazeni);
            int br;
            do
            {
                int a = int.Parse(Console.ReadLine());
                if(a==num)br=1;
                else br=0;
            }while(br!=1);
        }
    }
}