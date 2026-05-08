/*
Write a program that will load one word and print it in 4 rows as an example. 
EXAMPLE:
car
    car
car
    car
*/

internal class Program
    {
    static void Main(string[] args)
    {

        Console.WriteLine("Upisi rijec: ");
            string a = Console.ReadLine();
    Console.WriteLine();
            Console.WriteLine($"{a}\n\t{a}\n{a}\n\t{a}");
    }
}
