/*
Load the four-digit number 
and print its digits
with the declaration of only one variable.
*/
internal class Program
    {
    static void Main(string[] args)
    {

        Console.WriteLine("UPISI 4 ZNAM BR:");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine($"znam tisucice je:{a / 1000}, stotica:{(float)(a / 100) % 10}, desetka: {(a %100) /10}, jedinica: {(float)a%10}");
    }
}
