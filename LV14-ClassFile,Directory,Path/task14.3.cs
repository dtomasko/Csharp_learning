
/*

Write a program that uses StreamWriter to write data to the file log.txt. The program should:
• Write the date and time the program was run to the file.
• Write information about each user input (for example, each time the user types text).
• If the file log.txt already exists, the program should append the new data to the end of the file,
rather than overwriting the existing contents.
*/


internal class Program
{
    static void Main(string[] args)
    {



        string path = @"C:\Users\Dominik\Desktop\";

        string text = "log.txt";
    //true dodaje, a false overwrite-a

        StreamWriter writer=new StreamWriter(path+text,true);
        writer.WriteLine($"Program started at: {DateTime.Now}");

        
        Console.WriteLine("upisi tekst (exit za izlaz)");

        while (true) {
            string a= Console.ReadLine();
            if (a == "exit") break;
            writer.WriteLine($"korisnik unio: {a}");
            
        
        }
        writer.Close();



    }
}