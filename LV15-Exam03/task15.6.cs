
/*
Write a program in C# that, after entering a string and an integer n, will convert the first letter of the string into lowercase letters. It uses methods of the String class. Print the string.

*/
internal class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("upisi string: ");
            string a = Console.ReadLine();

        Console.WriteLine("upisi n: ");
        int n=int.Parse(Console.ReadLine());

        string b = a.Substring(0, n).ToLower();
        string c= a.Substring(n,a.Length-n);
        string rezultat = string.Concat(b, c);
        Console.WriteLine(rezultat);

    }
}