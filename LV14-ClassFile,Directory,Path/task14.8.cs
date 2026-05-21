/*

Write a program that takes the user-entered path to file and
prints the absolute path, file name, and file extension using the Path class.

*/

internal class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("upisi path do datoteke: ");
        string path = Console.ReadLine();


        string apsPath = Path.GetFullPath(path);
        string naziv = Path.GetFileName(path);
        string ekstenzija=Path.GetExtension(path);
        Console.WriteLine(apsPath);
        Console.WriteLine(naziv);
        Console.WriteLine(ekstenzija);
        }
    }
