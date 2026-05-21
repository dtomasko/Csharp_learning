


//solve task 14.3 using class File instead

internal class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\Dominik\Desktop\log.txt";
        //append jer moramo dodati ne overwrite
        File.AppendAllText(path, $"Program pokrenut: {DateTime.Now}\n");

        Console.WriteLine("Upiši tekst (exit za izlaz)");

        while (true)
        {
            string unos = Console.ReadLine();

            if (unos == "exit") break;

            File.AppendAllText(path, $"Korisnik unio: {unos}\n");
        }
    }
}
