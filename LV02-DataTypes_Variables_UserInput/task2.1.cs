/*
Load the name and surname for 2 students
and their age and print them with a tabular set
of compositions. Example: name surname year 
                           Ivan Horvat 17
                           Ana Markovic 18
*/

  internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesite ime prvog učenika:");
        string ime1 = Console.ReadLine();

        Console.WriteLine("Unesite prezime prvog učenika:");
        string prezime1 = Console.ReadLine();

        Console.WriteLine("Unesite broj godina prvog učenika:");
        int godine1 = int.Parse(Console.ReadLine());

    
        Console.WriteLine("Unesite ime drugog učenika:");
        string ime2 = Console.ReadLine();

        Console.WriteLine("Unesite prezime drugog učenika:");
        string prezime2 = Console.ReadLine();

        Console.WriteLine("Unesite broj godina drugog učenika:");
        int godine2 = int.Parse(Console.ReadLine());

        
        Console.WriteLine("\nIme\tPrezime\tGodine");
        Console.WriteLine($"{ime1}\t{prezime1}\t{godine1}");
        Console.WriteLine($"{ime2}\t{prezime2}\t{godine2}");
    }
}
