
/*

Write a program in C# that will ask for text input from the keyboard. Write the text to the file text.txt .
Before creating the file, check if the file text.txt exists. If it does, move it to the temp folder that the program will create. 
Print the text from the file text.txt by reversing the order of the lines (the first becomes the last, the second to last, etc.)
*/
internal class Program
    {
        static void Main(string[] args)
        {


        string path = @"C:\Users\Dominik\Desktop";
        string[] text = new string[100];
        int j = 0;
        while (true)
        {

            Console.WriteLine("Upiši tekst:");
            string b = Console.ReadLine();
            if (b != "exit") text[j] = b;
            else break;
            j++;
           
            
        }

     
        if (!File.Exists(path+@"\tekst.txt"))
        {
            File.WriteAllLines(path + @"\tekst.txt", text);
            string[] a = File.ReadAllLines(path + @"\tekst.txt");

            Console.WriteLine("Sadržaj datoteke obrnutim redoslijedom:");

            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
        else
        {
           

      
            Directory.CreateDirectory(path+@"\temp");

           
           
            File.Move(path + @"\tekst.txt", path + @"\temp"+@"\tekst.txt");

           
            File.WriteAllLines(path + @"\temp" + @"\tekst.txt", text);
            string[] a = File.ReadAllLines(path + @"\temp" + @"\tekst.txt");

            Console.WriteLine("Sadržaj datoteke obrnutim redoslijedom:");

            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(a[i])) Console.WriteLine(a[i]);

            }
        }
      
      
    }
}
