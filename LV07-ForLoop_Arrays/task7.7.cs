/*
Tracking the number of visits on the website.
You have a number of 28 numbers representing the number of website visits each day for 4 weeks.
Find a week that had the largest number of visits.
Calculate the average number of visits on the website for 4 weeks.
Determine which day of the week (pon, ut, sri, company, five, sub or ned) was most visited during 4
week.
Count all days when the number of visits was less than 100, and mark the number of visits less than 50
as "critical days".
Find a percentage of the day the number of visits was higher than 1000.

*/

 class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 7] { { 1111, 2000, 30, 450,20, 1299, 994 }, {100000, 2, 239, 430, 123, 230, 120 }, { 30, 123, 6542, 40, 43, 23, 163 }, { 123, 64, 43, 75,76, 39,549 } };
            int[] pw = new int[4] { 0, 0, 0, 0 };
            int[] pd = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            int mpw = 0, nt = 0, sm = 0, mpd = 0, nd = 0,mos=0;
            int k = 0, post = 0;
            double sr = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    pw[i] += a[i, j];
                    sm += a[i, j];
                    pd[j] += a[i, j];
                    if (pd[j] > mpd) { mpd = pd[j]; nd = j+1; }
                }
                if (mpw < pw[i]) { mpw = pw[i]; nt = i + 1; }
            }
            Console.WriteLine((double)sm / 28);
            Console.WriteLine($"{nt}. tjedan je imao najvise posjeta, to je {mpw}");
            Console.WriteLine($"{nd}. dan u tjednu je imao najvise posjeta, to je {mpd}");

            Console.WriteLine("Kriticni dani su:");
            for(int i = 0;i < 4;i++) 
            {
                for(int j = 0;j < 7;j++)
                {
                    if (a[i, j] < 50) Console.WriteLine((k+1) + "-ti");
                    if (a[i, j] < 100) mos += a[i, j];
                    if (a[i, j] > 100) post++;
                    k++;
                }
            }
            sr = (double)((post / 28.0) * 100);
            Console.WriteLine($"Zbroj svih ispod 100: {mos}");
            Console.WriteLine($"{sr:F2}% su iznad 1000 posjeta");


        }
    }