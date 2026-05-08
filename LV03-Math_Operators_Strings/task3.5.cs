
/*
Calculating the average grade
Write a program that asks users to enter five grades.
Then using arithmetical operators calculate the average grade.
If the average is greater than or equal to 4.5, 
print the message: "Great success". 
If the average is less than 4.5 print: "Good success".
*/
internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[5];
        int zbr = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"upisi {i + 1}. ocjenu");
            a[i] = int.Parse(Console.ReadLine());
            zbr += a[i];

        }
        float ar = (float)zbr / 5;
        if (ar >= 4.5) Console.WriteLine("odlican");
        else Console.WriteLine("dobar");
    }
}
