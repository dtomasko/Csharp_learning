/*
Analysis of financial transactions.
You have a series of 7 elements that represent daily business account transactions during
one week. 
Any transaction may be positive (increase in the state) or negative (reduction
states).
Print all transactions that were negative (loss of money). 
Calculate the total sum of all transactions in a week. 
Find the maximum daily loss (maximum negative amount).
Determine what day he had the biggest income and which day had the biggest loss.
At the end of the week, calculate the final account balance (initial balance is € 1,000).

*/

class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, -2, 3, 4, -5, 6, -7};
            int sum=0,min=0,max=0,dp=0,dm=0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i]<0)Console.WriteLine(a[i]);
                sum += a[i];
                if (a[i] < min)
                {
                    min = a[i];
                    dm = i;
                }
                if (a[i] > min)
                {
                    max = a[i];
                    dp = i;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(min);
            Console.WriteLine(dp+1);
            Console.WriteLine(dm+1);
            Console.WriteLine(sum+1000);
        }
    }
