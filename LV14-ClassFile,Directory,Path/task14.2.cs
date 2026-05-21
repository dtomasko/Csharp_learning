
/*
Write a program that uses StreamReader to read the contents of the file text.txt. The program should:
• Print all lines from the file to the screen.
• If the file does not exist, the program should print the message "File does not exist".
• If the file contains more than 100 lines, the program should print only the first
100 lines.
*/

internal class Program
{
    static void Main(string[] args)
    {



        string path = @"C:\Users\Dominik\Desktop\";

        string text = "text.txt";
        int br = 0;
        StreamReader reader=new StreamReader(path+text);

        if (!File.Exists(path + text)) Console.WriteLine("Datoteka ne postoji");
        else
        {
            while (true) {
                string tekst = reader.ReadLine();
                if (tekst == null) break;
                if (br == 100) break;
                else Console.WriteLine(tekst);
                br++;
            }
           
            
        }

    }
}
