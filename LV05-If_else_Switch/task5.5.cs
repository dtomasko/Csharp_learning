
/*
Declare four float-type variables and one char-type variable.
Then load five values: three decimal numbers and one character (which can be a letter, figure, or symbol).
For each of the values, check whether the number is positive or negative, 
and if character, check if it is letter, capital, lowercasse or symbol.
Print appropriate messages for each value.
If the number loaded is positive, print its square; if negative, print its absolute
amount.


*/

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine()), 
                b = Convert.ToDouble(Console.ReadLine()), 
                c = Convert.ToDouble(Console.ReadLine()),
                d = Convert.ToDouble(Console.ReadLine());
            char x = Convert.ToChar(Console.ReadLine());
            switch (a > 0)
            {
                case true: Console.WriteLine(a * a); break;
                case false: Console.WriteLine(Math.Abs(a)); break;
            }
            switch (b > 0)
            {
                case true: Console.WriteLine(b * b); break;
                case false: Console.WriteLine(Math.Abs(b)); break;
            }
            switch (c > 0)
            {
                case true: Console.WriteLine(c*c); break;
                case false: Console.WriteLine(Math.Abs(c)); break;
            }
            switch (d > 0)
            {
                case true: Console.WriteLine(d*d); break;
                case false: Console.WriteLine(Math.Abs(d)); break;
            }
            if ((int)x >= 48 && (int)x <= 57) Console.WriteLine($"{x} je broj.");
            if ((int)x >= 65 && (int)x <= 90) Console.WriteLine($"{x} je veliko slovo");
            if ((int)x >= 97 && (int)x <= 122) Console.WriteLine($"{x} je malo slovo");
            else Console.WriteLine($"{x} je simbol");

        }
    }
}