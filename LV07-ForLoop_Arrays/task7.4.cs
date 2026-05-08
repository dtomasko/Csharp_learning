
/*
Initiate an integer array size 10,
and print all elements of it below each other. 
Then print the average value of the array.
Then print the max value. 
*/
internal class Program
    {
        static void Main(string[] args)
        {
            int[] a=new int[10];
            int zbr = 0;
            int max=0;
            for (int i = 0; i <10; i++)

            {
                
                a[i]=i;
                Console.WriteLine(a[i]);
               zbr=zbr+a[i];
               if(a[i]>max)max=a[i];

            }
            float avg = (float)zbr / 10; ;
            Console.WriteLine(avg);
            Console.WriteLine(max);

        }
    }
