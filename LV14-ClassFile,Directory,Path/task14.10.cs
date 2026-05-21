
/*
Write a program that saves 100 random numbers from 0 to 1 in the file random_numbers.txt. 
The program saves the file random_numbers.txt in the Csharp directory
that must be created. If the CSharp directory already exists, the program does not create it. 
The program also checks for the existence of the random_numbers.txt file in the Csharp folder. If the file already exists,
the program moves the old file to the Temp subfolder and renames it to slucani_brojevi_staro.txt 
(the Temp subdirectory is created by the program itself, but before that it has to check if it already exists). Note: The Random class is used to generate random numbers.
The NextDouble() method returns a random number between 0 and 1, the Next() method returns a random integer. Two arguments can be sent to the Next() method,
the first determines the lower limit (inclusive), and the second the upper limit (exclusive).


*/

internal class Program
    {
        static void Main(string[] args)
        {

        string path = @"C:\Users\Dominik\Desktop\";
        string txtPath = @"C:\Users\Dominik\Desktop\CSharp\slucajni_brojevi.txt";

        if (!Directory.Exists(path + "CSharp"))
        {
            Directory.CreateDirectory(path + "CSharp");
        }

        if (!File.Exists(txtPath))
        {
            File.Create(txtPath);

        }
        else
        {
            if (!Directory.Exists(path + @"CSharp\Temp"))
            {

                Directory.CreateDirectory(path + @"CSharp\Temp");

            }
            File.Move(txtPath, path + @"CSharp\Temp\slucajni_brojevi_staro.txt");
            
        }

        Random rnd = new Random();
        StreamWriter sw = new StreamWriter(txtPath);

        for(int i = 0; i < 100; i++)
        {

            double br=rnd.NextDouble();
            sw.Write(br);
        }
        sw.Close();





    }
    }

