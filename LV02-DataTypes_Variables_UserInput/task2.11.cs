
/*Write a program that prints a table of 10 randomly generated characters of ASCIIcode (char)
, their corresponding byte values and shows whether the characters are alphabetical signs (bool). 
Format the printing in the form of a three-column table:
 Sign (char), ASCII value (byte),Abeced is a sign (bool).
For example:
| Sign | ASCII | Alphabetical |
| A | 65 | True |
| B | 66 | True |
| 1 | 49 | False |
*/
internal class Program
{
    static void Main(string[] args)
    {
        byte[] a = new byte[10];
        Random rnd = new Random();
        char[] ascii = new char[10];
        bool[] abc = new bool[10];
        for (int i = 0; i < 10; i++)
        {
            a[i] = (byte)rnd.Next(32, 127);
            ascii[i] = (char)a[i];
            abc[i] = ((a[i] <= 90 && a[i] >= 65) || (a[i] >= 97 && a[i] <= 122));

        }
        Console.WriteLine("|Znak|ASCII|Abced|");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"|{ascii[i]}|{a[i]}|{abc[i]}|");
        }
        }
}
