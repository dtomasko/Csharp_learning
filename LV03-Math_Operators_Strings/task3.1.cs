
/*
Declare 3 string type variables. 
In one, load the name and surname of the first student,
in the third one merged the name and surname. 
Also load the age of the student. Print it like the example.
EXAMPLE:
name and surname age
Ivan Horvat 17

*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("upisi ime: ");
        string  ime=Console.ReadLine();
        Console.WriteLine("upsii prezime: ");
        string prezime=Console.ReadLine();
        Console.WriteLine("upisi godine ucenika: ");
        int god=int.Parse(Console.ReadLine());
        string imeiprez=ime+' '+prezime;
        Console.WriteLine("Ime i prezime\t\tgodine");
        Console.WriteLine($"{imeiprez}\t{god}");

    }
}