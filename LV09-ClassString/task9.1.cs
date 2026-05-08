/*
Write a program that will load a word into a variable of type string, and determine and print how many letters the word has. All letters must be printed one below the other. 
EXAMPLE: Cinema
output: n = 4
K
i
n
o

*/

 internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("upisi string: ");
            string a = Console.ReadLine();

            int n = a.Length;
            Console.WriteLine($"rijec ima {n} slova.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
