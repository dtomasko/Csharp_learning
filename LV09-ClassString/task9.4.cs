/*
Initialize the string with "O vo je su pe r", 
and print the indexes of whitespaces.
(IndexOf() method) output:
1
4
7
10
13

*/

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string a = "O vo je su pe r";
            int indeks = a.IndexOf(" ");
            
            while (indeks != -1)//ako nema indeksa onda je jednako -1 
            {

                Console.WriteLine(indeks);
                indeks=a.IndexOf(" ",indeks+1);//počinje od indeks+1 
            }

        }
     
    }
}
