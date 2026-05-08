
/*
Write a program that will define 2 lists of type double, and will also define a third list of type
double in which the members will be all the members from the first two lists. The program must work properly for
arbitrary number of list members. Prompt the user to enter list elements until they type a letter.
Print the lists.

*/

internal class Program
{
    private static void Main(string[] args)
    {

      
        
        List<double> doubleList1 = new List<double>();
        List<double> doubleList2 = new List<double>();
        List<double> doubleList3 = new List<double>();
     
       
            Console.WriteLine("upisi kolko elem za 1. listu: ");
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("upisi br za 1 listu:");
                string a = Console.ReadLine();
                if (!double.TryParse(a, out double broj))
                {
                    Console.WriteLine("kraj");
                    break;
                }

                else
                {
                    doubleList1.Add(broj);

                }
            }
            Console.WriteLine("upisi kolko elem za 2. listu: ");
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("upisi br za 2 listu:");
                string a = Console.ReadLine();
                if (!double.TryParse(a, out double broj))
                {
                    Console.WriteLine("kraj");
                    break;
                }

                else
                {
                    doubleList2.Add(broj*1.0);

                }
            }
        
        doubleList3.AddRange(doubleList1);
        doubleList3.AddRange(doubleList2);
        foreach (double d in doubleList3)
        {

        Console.WriteLine(d); }



    }
}