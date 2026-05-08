

/*
The task is to enable the Petra to enter product name(data type: string) 
and product prices (data type: double). 
The program should format the name of the product so that the first letter is capital,
and the rest lower case, and print prices with two decimal places. 
We think Petra is entering all lower case letters
(to obtain a capital letter ASCII lowercase code, 32 should be taken away).
Also, all products should be printed in the format:
"Product: [product name], Price: [price - on two decimals (format file f)]".
*/

internal class Program
{
    private static void Main(string[] args)
    {
        string naziv;
        double cijena;
        char[] c = new char[100];
        Console.WriteLine("upisi naziv proizvoda: ");
        naziv = Console.ReadLine();
        Console.WriteLine("upisi cijenu: ");
        cijena = double.Parse(Console.ReadLine());
        char a = naziv[0];
        char b = (char)(a - 32);
        c[0] = b;
        for (int i = 1; i < naziv.Length; i++) { 
            
        c[i] =naziv[i];

        }
        string rezultat=new string (c);
        Console.WriteLine($"\"Proizvod: {rezultat}, Cijena: {cijena:F2}");
      
    }
}
/*
OR THIS: 
internal class Program
{
    private static void Main(string[] args)
    {
        string naziv;
        double cijena;
        char[] c = new char[100];
        Console.WriteLine("upisi naziv proizvoda: ");
        naziv = Console.ReadLine();
        Console.WriteLine("upisi cijenu: ");
        cijena = double.Parse(Console.ReadLine());
        char a = naziv[0];
        char b = (char)(a - 32);
        Console.Write($"Proizvod: {b}");
        for (int i = 1; i < naziv.Length; i++)
        {
            Console.Write(naziv[i]);
        }
        Console.WriteLine($"\ncijena {cijena:F2}");
    }
}
*/