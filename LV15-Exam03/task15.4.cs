
/*
Write a program in C# that enters n integers into the file numbers.txt. Ask the user to enter the number n and enter the integers from the keyboard. 
Check the input of integers (otherwise return to re-entering). Read the data from the file numbers.txt (you must not create an auxiliary string while entering integers or immediately check for divisibility by 3)
and then write to the file dijliviS3.txt how many numbers in the file numbers.txt are dijliviS3.txt. Print the files numbers.txt and dijliviS3.txt.

*/
internal class Program
    {
    static void Main(string[] args)
    {

        string path = @"C:\Users\Dominik\Desktop\brojevi.txt";
        Console.WriteLine("Upisi n: ");
        int n=int.Parse(Console.ReadLine());
        using (StreamWriter sw = new StreamWriter(path))
        {
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"upisi {i + 1}. broj: ");
                if (int.TryParse(Console.ReadLine(), out int broj))
                {


                    sw.WriteLine(broj);


                }

                else
                {
                    Console.WriteLine("ne ispravan unos.");
                    i--;
                }

            }

        }
        string[] text = File.ReadAllLines(path);
        int br = 0;
        foreach (string s in text) { 
        
        int broj=int.Parse(s);
            if (broj % 3 == 0) br++;
        }
        File.WriteAllText(@"C:\Users\Dominik\Desktop\djeljiviS3.txt",br.ToString());


        }

    }
    
