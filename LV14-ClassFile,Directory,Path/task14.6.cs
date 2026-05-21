
/*
Write a program that searches a directory and its subdirectories, and
prints all files with the extension .txt.
The program should use recursion in order to
visited subdirectories.

*/


internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Dominik\Desktop\Test";

            if (Directory.Exists(path))
            {
                PretraziDirektorij(path);
            }
            else
            {
                Console.WriteLine("Direktorij ne postoji.");
            }
        }

        static void PretraziDirektorij(string path)
        {
            
            string[] datoteke = Directory.GetFiles(path, "*.txt");

            foreach (string s in datoteke)
            {
                Console.WriteLine(s);
            }

           
            string[] direktoriji = Directory.GetDirectories(path);

            
            foreach (string s in direktoriji)//rekruzivna
            {
                PretraziDirektorij(s);
            }
        }
    }
