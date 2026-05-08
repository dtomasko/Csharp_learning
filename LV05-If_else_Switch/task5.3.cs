
/*
Declare a char type variable and load it a small or large letter or digit.
Then first check if the char is a lower case letter,if not
check if it is a capital letter or a number.
Print a message and then if the char is a letter change it
from lower case to capital or vice versa and
print it out.
*/

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("upisi znamenku ili slovo: ");
            char a = char.Parse(Console.ReadLine());
            char b;
            if (Char.IsLower(a))
            {
                Console.WriteLine($"{a} je malo slovo.");
                b = (Char.ToUpper(a));
                Console.WriteLine($"{b} ucitano slovo obrnuto.");
            }
            else if (Char.IsUpper(a))
            {
                Console.WriteLine($"{a} je veliko slovo.");
                b = (Char.ToLower(a));
                Console.WriteLine($"{b} ucitano slovo obrnuto.");
            }
            else if (Char.IsDigit(a)) Console.WriteLine($"{a} je znam.");
        }
    }
}
