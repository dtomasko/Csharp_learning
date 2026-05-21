

/*

Write a program in C# that asks the user to enter the path to a folder. If the folder exists, print everything
files and subfolders within it (first level only). After that, it asks the user to enter the path to
other folders. Move all .txt files from the first folder to the second using File.Move. If some file
it already exists in the destination folder, does not move it and prints the message.

*/

internal class Program
    {
    static void Main(string[] args)
    {



        Console.WriteLine("upisi path: ");
        string path = Console.ReadLine();

        if (Directory.Exists(path))
        {
            string[] datoteke = Directory.GetFiles(path);
            foreach (string s in datoteke) {

                Console.WriteLine("datoteka: " + s);
            }

            string[] dir = Directory.GetDirectories(path);
            foreach (string s in dir) {
                Console.WriteLine("Direktorij: " + s);
            }
        }
        Console.WriteLine("upisi 2. path: ");
        string path2 = Console.ReadLine();

        if (Directory.Exists(path2))
        {
            string[] txtfiles = Directory.GetFiles(path, "*.txt");
            foreach (var file in txtfiles) {
                string fileName = Path.GetFileName(file);
                if (!File.Exists(path2 + @"\" + fileName)){
                    File.Move(file, path2 + @"\" + fileName);
                }
                else Console.WriteLine("datoteka "+fileName+" već postoji");

            }
        } 
        else Console.WriteLine("ne postoji 2. path");
    
    
    }
    }
