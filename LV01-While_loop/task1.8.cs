
/*Task 4: Multi-action calculator.
Write a simple calculator that allows the user to enter two numbers
and select the four basic mathematical operations. 
Developments should print the result of the operation and continue to operate until the user enters the "end"*/

using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("upisi prvi br: ");
        int a=int.Parse(Console.ReadLine());

        Console.WriteLine("upisi drugi br: ");
        int b = int.Parse(Console.ReadLine());
        while (true)
        {
            Console.WriteLine("Odaberi operaciju: \n+ za zbrajanje\t\t- za oduzimanje\n* za množenje\t\t/ za dijeljenje\n--------------------------------\nupisi 'kraj' za izlaz iz programa");
            string unos = Console.ReadLine();
            if (unos == "kraj") break;
            else
            {
                if (unos == "+") Console.WriteLine($"Retultat je {a + b}");
                if (unos=="-") Console.WriteLine($"Reza he {a - b}");
                if (unos=="*") Console.WriteLine($"Reza je {a * b}");
                if (unos=="/" && b != 0) Console.WriteLine($"Reza je {(float)a / b}");
                if (unos == "/" && b == 0) Console.WriteLine("ne moze se djelit n 0");

            }
        }
        
       

    }
}