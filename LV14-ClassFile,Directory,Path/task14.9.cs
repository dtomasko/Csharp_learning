/*Write a program that checks if the user entered the path
directory or file using the Path.GetExtension() method and prints
appropriate message.*/


internal class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("upisi path do datoteke ili dir: ");
        string path = Console.ReadLine();


        string a = Path.GetExtension(path);
        if (string.IsNullOrEmpty(a)) {
            Console.WriteLine("direktorij");
        
        }
        else Console.WriteLine(a + " datoteka");
      
        }
    }
