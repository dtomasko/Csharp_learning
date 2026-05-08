
/*
Load three integer variables a, b and c 
and calculate the integer and decimal result of the formula
y=a*(a+b)/c.
Then print both values (int and decimal)
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("upisi 1 broj:  ");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine("UPISI 2 BROJ: ");
        int b=int.Parse(Console.ReadLine());
        Console.WriteLine("upisi 3 broj:  ");
        int c = int.Parse(Console.ReadLine());
        float y = (float)a * (a + b) / c;
        Console.WriteLine($"cjelobrojna: {(int)y}, decimalna {(float)y}");





    
    }
}