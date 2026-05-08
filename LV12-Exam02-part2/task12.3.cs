/*
Write a program in C# that creates a series of strings string[ ]
from the typed text from the keyboard so that each
the word from the text becomes a new string in the sequence.

*/

  internal class program{
    
    private static void Main(string[] args)
    {
        Console.WriteLine("upisi tekst");
        string a = Console.ReadLine();
        string[] b = new string[20];
        b = a.Split(" ");
        foreach (string s in b) {
            Console.WriteLine(s);
        }

    }
  }