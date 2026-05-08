/*
Write a program in which you will ask the user to enter a string of characters, 
then you will call the following methods and specify the corresponding variables:
 • Uppercase(), which will contain the entered string converted to uppercase letters
• Lowercase() which will contain the entered string converted to lowercase letters
• PrvaTri(), which will contain the first three characters of the entered string
• LastFive(), which will contain the last five characters of the entered string 
• _8_11(), which will contain the 8th to 11th characters of the entered string. 
Finally, print the values ​​of the variables.


*/


using System.Numerics;
using System.Reflection.Metadata;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("upisi niz znakova: ");
            char[] a = new char[100];
            for (int i = 0; i < a.Length; i++)
            {

                a[i] = char.Parse(Console.ReadLine());
            }
            string b= new string(a);
            string velika = Velika(b);
            string mala = Mala(b);
            string prvaTri = prvatri(b);
            string zadnjihPet = zadnjapet(b);
            string osmijedanaest = _8_11(b);

            Console.WriteLine("Velika: " + velika);
            Console.WriteLine("Mala: " + mala);
            Console.WriteLine("PrvaTri: " + prvaTri);
            Console.WriteLine("ZadnjihPet: " + zadnjihPet);
            Console.WriteLine("Od 8. do 11.: " + osmijedanaest);



        }

       static string Velika(string b)
        {

            return b.ToUpper();

        }

        static string Mala(string b)
        {
            return b.ToLower();
        }

        static string prvatri(string b) {
        
        return b.Substring(0,3);
        }

        static string zadnjapet(string b)
        {

            return b.Substring(b.Length-5);
        }
        static string _8_11(string b)
        {

            return b.Substring(8,3);
        }


    }

}
