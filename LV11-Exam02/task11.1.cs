/*
Write a program in C# that, after inputting a string and an integer n, the first n letters in the string
convert to lowercase letters.

*/

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("upisi string: ");
        string a=Console.ReadLine();

        Console.WriteLine("upisi n: ");
        int n=int.Parse(Console.ReadLine());
  
 
        string b=a.Substring(0,n).ToLower();
        string c=a.Substring(n);
       
        Console.WriteLine($"prvih n slova malo: {b+c}");
    }
}
