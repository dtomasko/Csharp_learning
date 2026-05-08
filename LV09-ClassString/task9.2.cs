/*Write a program that loads a string and asks the user
from which place in the string the characters should be printed
as capital letters. Save and print the new string. 
(Use methodToUpper())

EXAMPLE: Ovo je sve.
n1 = 3
n2 = 8
output: OvO JE Sve.
*/

internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("upisi string: ");
            string a = Console.ReadLine();

            Console.WriteLine("upisi od kojeg do kojeg mjesta: ");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("upisi od kojeg do kojeg mjesta: ");
            int c = int.Parse(Console.ReadLine());


            string novi = a.Substring(b-1, c - b+1).ToUpper();
            string real = string.Concat(a.Substring(0,b-1),novi,  a.Substring(c));
            Console.WriteLine(real);
        }
    }
