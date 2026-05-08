
/*A calculator of square roots and potential
Write a program that accepts two numbers: one integer (int) and one decimal number (double).
The program should be calculated and print a square root of both numbers
and a potentiated number. The results should be displayed with different decimal numbers 
(for example, integers without decimals, and decimal with three decimal places).
*/
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Unesite cijeli broj:");
        int a = int.Parse(Console.ReadLine());


        Console.WriteLine("Unesite decimalni broj:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine($"Korijen cjelog br: {(Math.Sqrt(a)):F0}, korijen dec broja: {(Math.Sqrt(b)):F3}, potencija prvog na drugi: {(Math.Pow(a,b)):F3}");
    }
}
