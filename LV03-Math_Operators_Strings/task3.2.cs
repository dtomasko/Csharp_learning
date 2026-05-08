/*
Declare two string-type variables and upload a name to one, and to the other one surname.
Then merge then into one string and individually print the letters of that string with intervals, the scorer.
Example:
The name Ana and the surname Ivic are loaded. 
You should print: A n a I v i c
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("upisi ime: ");
        string ime = Console.ReadLine();
        Console.WriteLine("upsii prezime: ");
        string prezime = Console.ReadLine();

        string imeiprez = ime + ' ' + prezime;
        for (int i = 0; i < imeiprez.Length; i++)
        {
            Console.Write($"{imeiprez[i]} ");



        }
    }
}
