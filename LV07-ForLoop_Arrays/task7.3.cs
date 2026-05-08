//Write a program that substracts numbers from number 100 between 2 to 8. Final result should be printed.
internal class Program
    {
        static void Main(string[] args)
        {
            int zbr = 100;
            for (int i = 2; i <=8; i++)

            {
                zbr = zbr - i;
              
            }
            Console.WriteLine(zbr);

        }
    }
