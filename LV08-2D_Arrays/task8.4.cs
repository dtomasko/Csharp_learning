/*
Load your name and create a field that has as many columns as the name has letters and ten rows.
Store the letters of your name in the first row, and the following rows contain letters 
that continue alphabetically. Print that field tabularly.

Note: you should use the English alphabet and after "z" comes "a"
EXAMPLE:
I v a n
j w b o
k x c p
l y d q
m z e r
n a f s
o b g t
p c h u
q d i v
r e j w


*/

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            char[,] ime = new char[10, 7];

            string ime_real = "dzminik";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    char slovo = (char)(ime_real[j] + i);
                    if (slovo>'z') slovo = (char)(slovo - 26);
                    // jer je ascii z=122 a=97
                    ime[i, j] = slovo;
                    
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(ime[i, j]);

                }
                Console.WriteLine();
            }
        }
    }
}
