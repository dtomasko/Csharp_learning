/*
Write a program that will declare a list of type int.
Ask the user for input list elements until the user types a letter. 
Define and print a list of type double in which the
be half the value from the first list.

*/

internal class Program
{
    private static void Main(string[] args)
    {

      
        List<int> intList = new List<int>();
        List<double> doubleList = new List<double>();

        while (true) {
            Console.WriteLine("upisi br: ");
            string a=Console.ReadLine();
            if(!int.TryParse(a, out int broj)){
                Console.WriteLine("kraj");
                break;
            }
            else
            {
                intList.Add(broj);
            }
        }

        for (int i = 0; i < intList.Count; i++) { 
        doubleList.Add(intList[i]/2.0);
        
        }
        foreach (int i in intList)
        {
            Console.WriteLine(i);
        }
        foreach(double d in doubleList)
        {
            Console.WriteLine(d);
        }
       
    }
}