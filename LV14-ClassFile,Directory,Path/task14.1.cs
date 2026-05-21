/*
Write a program that copies the contents of the source.txt file to a new one
the destination.txt file. The program should check if the files exist and process them
potential errors when copying.

*/

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\student\Desktop\";
            string izvor = "izvor.txt";
            string odrediste = "odrediste.txt";
            File.WriteAllText(path + izvor, "Sadrzaj za kopiranje");
            File.WriteAllText(path + odrediste, File.ReadAllText(path + izvor));
        }
    }
}