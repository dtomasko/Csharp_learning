 
 /*
Declare two string-type variables 
and upload a name to one and surname to the other,
and print the name and surname as one by connecting then.*/
 
 internal class Program{
 
 static void Main(string[] args)
    {

        Console.WriteLine("Unesite ime:");
        string ime = Console.ReadLine();

        Console.WriteLine("Unesite prezime:");
       string  prezime = Console.ReadLine();

        string imeIPrezime = ime + " " + prezime;
        Console.WriteLine($"{imeIPrezime}");

    }
}
