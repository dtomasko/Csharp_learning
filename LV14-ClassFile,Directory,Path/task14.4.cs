

//solve task 14.3 using class File instead

internal class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\Dominik\Desktop\text.txt";

        if (File.Exists(path))
        {
            string[] linije = File.ReadAllLines(path);

            int br = 0;
            for(int i = 0; i < linije.Length; i++)
            {
                if (br == 100) break;
                Console.WriteLine(linije[i]);
                br++;
            }
        }
        else
        {
            Console.WriteLine("Datoteka ne postoji");
        }
    }
}
