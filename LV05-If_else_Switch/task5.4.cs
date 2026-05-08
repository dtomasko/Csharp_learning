

/*
Load three positive int variables a, b and c 
and calculate the formula y=a*(a+b)/c.
Then check which of the following cases y belongs to:
0 to 5 and even number, 0 to 5 and odd number,
more than 5 and even number, more than 5 and odd numbers.
Using switch case.
*/
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi 1. broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Upisi 2. broj: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Upisi 3. broj: ");
            int c = int.Parse(Console.ReadLine());
            int y = a * (a + b) / c;
            int slucaj = 0;
            if (y >= 0 && y <= 5 && y % 2 == 0) slucaj = 1;
            else if (y >= 0 && y <= 5 && y % 2 != 0) slucaj = 2;
            else if (y > 5 && y % 2 == 0) slucaj = 3;
            else if (y > 5 && y % 2 != 0) slucaj = 4;

          
            switch (slucaj)
            {
                case 1:
                    Console.WriteLine("y je od 0 do 5 paran");
                    break;
                case 2:
                    Console.WriteLine("y je od 5 do 0 nepar");
                    break;
                case 3:
                    Console.WriteLine("y je veci od 5 i paran");
                    break;
                    case 4:
                    Console.WriteLine("y je veci od 5 i nepar");
                    break;
            }
        }
    }
}