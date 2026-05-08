
/*

Load three integer variables a, b and c that represent the lengths of the triangle pages.
Check if these three pages are a possible triangle according to one of the known formulas (sum every two
pages must be larger than third). If the variables are the valid pages of the triangle, calculate its
range and surface using the Herons formula. If the surface is less than 50, print a message about
small area, if greater than 100, print a message about the large surface, and if it is between 50 and 100,
print a message about the middle surface.
*/

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()),
                b = Convert.ToInt32(Console.ReadLine()),
                c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && a + c > b & c + b > a)
            { 
                double s =(a + b + c) / 2; 
                double p = Math.Sqrt(s * (s - a) * (s - b) * (s - c)); 
                Console.WriteLine($"Opseg je {s * 2}");
                if (p >= 50 && p <= 100) Console.WriteLine("Povrsina je srednja");
                if (p < 50) Console.WriteLine("Povrsina je mala");
                if (p > 100) Console.WriteLine("Povrsina je velika");
            }
        }
            
    }
}