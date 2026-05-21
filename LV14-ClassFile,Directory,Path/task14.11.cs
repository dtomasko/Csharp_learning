

/*

Write a program that asks for your name. Then it creates a directory with your name on the desktop path 
(it is necessary to check whether the directory already exists). In the directory with your name,
it will create a file with your name (name).txt (*it is necessary to check whether the file already exists). 
Enter the names of 5 students in your class from the keyboard and write the names into that file, each name on a line. 
From the file, print only the 2nd and 4th names to the screen. *If the file already exists, move it to the temp subdirectory
(it is necessary to check whether the temp subdirectory already exists), but add today's date to the file name (to avoid deleting the existing file).

*/

internal class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Upisi ime svoje : ");
        string ime = Console.ReadLine();

        string path = @"C:\Users\Dominik\Desktop\";
        

        if (!Directory.Exists(path + ime)) { 
        
            Directory.CreateDirectory(path + ime);

        }
        

        if (!Directory.Exists(path + "temp"))
        {

            Directory.CreateDirectory(path + "temp");
        }
        if (File.Exists(path + ime + @"\" + ime + ".txt"))
        {

            string pathTemp = path + @"temp\" + ime + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".txt";
            File.Move(path + ime + @"\" + ime + ".txt", pathTemp);
        }

        StreamWriter sw = new StreamWriter(path + ime + @"\" + ime + ".txt");
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Upisi ime lika iz raz: ");
            sw.WriteLine(Console.ReadLine());



        }
        sw.Close();


        string[] imena = File.ReadAllLines(path + ime + @"\" + ime + ".txt");

        Console.WriteLine(imena[1]);
        Console.WriteLine(imena[3]);





    }
    }
