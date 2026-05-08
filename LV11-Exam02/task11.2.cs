/*
Write a program in C# that asks for the input of an array (Array[ 100 ]) of strings as long as the keyboard
does not type Space. Copy that Array into a new Array with only written strings and sorted
alphabetically, without empty strings. Print a new Array using a foreach loop.
*/

internal class Program
{
    private static void Main(string[] args)
    {

        string[] a = new string[100];
        string[] b = new string[100];
        Console.WriteLine("upisi string: ");
        a[0] = Console.ReadLine();
        int i = 1;
        int j = 0;

        while (true) {

            if (a[i] == " ") break;
            else
            {
                i++;
                Console.WriteLine("upisi string: ");
                a[i] = Console.ReadLine();
                b[j] = a[i];
               
                j++;
            }



        }
        Array.Sort(b);
        foreach (string s in b) {
            if (!string.IsNullOrEmpty(s)) 
            {

                Console.WriteLine(s);
            }
        }}}
       
    
