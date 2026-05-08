
/*
Declare 3 float type variables.
Then enter three integers or decimal values to those variables. 
Then for each variable it should be checked whether it is int or decimal and
print on the screen a matching message.
*/

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi prvi broj: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Unesi treći broj: ");
            float c = float.Parse(Console.ReadLine());

            provjera(a);
            provjera(b);
            provjera(c);
        }

       
        static void provjera(float x)
        {
            if (x == (int)x)
                Console.WriteLine($"{x} je cijeli broj");
            else
                Console.WriteLine($"{x} je decimalni broj");
        }
    }
}
