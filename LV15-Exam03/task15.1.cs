
/*
Write a program in C# that asks for the entry of the directory path. If the directory does not exist, it creates it in it
creates a Temp subdirectory. If the directory already exists, the program deletes it.

*/

internal class Program
    {
        static void Main(string[] args)
        {



        Console.WriteLine("upisi putanju: ");
        string path=Console.ReadLine();

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Directory.CreateDirectory(path + @"\temp");
        }
        else
        {

            Directory.Delete(path);
        }


    }
    }