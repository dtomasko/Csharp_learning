
/*
Write a program in C# that asks for the path of a file on the desktop. If the file exists, print the 3rd line of text from the file to the screen. If the file does not exist, create it and type in: 
"I'm going to the beach.", new line, "I'm going to program on the beach.", new line, "Ivan".

*/

internal class Program
    {
    static void Main(string[] args)
    {

        Console.WriteLine("upisi path: ");
        string path = Console.ReadLine();
        if (!File.Exists(path)) { 
        
        
            string[] text={"Idem na more.","Programirat ću na plaži.","Ivan"};
            File.WriteAllLines(path,text);//ne treba napravit file jer .WriteAllLines to radi sam

        }
        else
        {

            string[] text=File.ReadAllLines(path);
            Console.WriteLine("3. redak: " + text[2]);

        }
    }
    }