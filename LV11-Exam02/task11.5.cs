/*
Write a program in C# that asks for string input. Split a string into an array (field) of characters. Print it out
an array of characters using a foreach loop.
*/

 
 internal class program{
 private static void Main(string[] args)
    {
        Console.WriteLine("upisi string");
        string a = Console.ReadLine();
        char[] b = a.ToCharArray();
        foreach(char znak in b)
        {
            Console.WriteLine(znak);
        }
       
    }
}