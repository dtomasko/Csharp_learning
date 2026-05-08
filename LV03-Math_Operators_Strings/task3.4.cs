

/*
Declare a variable called (a) type of float and upload an integer to it.
Then declare a variable and give it the value of varable a
while using explicit conversion. Print that value.
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Unesi cijeli broj: ");
        float a = float.Parse(Console.ReadLine());
        int b = (int)a;
        Console.WriteLine(b);





    }
}