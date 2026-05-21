/*


Write a program that moves all files with the extension .jpg 
from the directory source_directory to the directory destination_directory.
The program should check whether both directories exist and handle errors during the move.

*/

internal class Program
    {
        static void Main(string[] args)
        {




        string path = @"C:\Users\Dominik\Desktop\";
        string izvDir = "izvorni_direktorij";
        string odrDir = "odredisni_direktorij";

        if (Directory.Exists(path + izvDir) && Directory.Exists(path + odrDir))
        {


            string[] jpgDat=Directory.GetFiles(path+ izvDir,"*.jpg");
            foreach(string s in jpgDat)
            {

                string datoteka = s.Substring(s.LastIndexOf("\\") + 1);
                string path2 = odrDir + "\\" + datoteka;
                File.Move(s, path+path2);
            }


        }
        else Console.WriteLine("dir ne postoji");



        }
    }
