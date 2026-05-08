//. Write a program in C# that removes all spaces from the typed text from the keyboard.

 internal class program{
 private static void Main(string[] args)
    {
        Console.WriteLine("upisi tekst");
        string a = Console.ReadLine();
        string rezultat = a.Replace(" ", "");
        Console.WriteLine(rezultat);

    }
}

