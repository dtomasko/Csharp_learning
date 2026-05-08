//Write a program similar to task 3, but print the average working time per day
   internal class Program
    {
        static void Main(string[] args)
        {
            int h, m, s;
            TimeSpan uk = new TimeSpan(0,0,0,0);
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Upisi vrijeme rada za {0}. dan(h,m,s):",i+1);
                h = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
                s = int.Parse(Console.ReadLine());
                TimeSpan vr = new TimeSpan(0,h,m,s);
                uk = uk + vr;
            }
            Console.WriteLine(uk.ToString());
        }
    }