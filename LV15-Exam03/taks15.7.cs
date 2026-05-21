
/*
Write a program in C# that will ask for elements in an ArrayList until the user types a Space. Create two lists List<string> and List<double> into which the program will transfer all elements from the first list according to their type. Print the lists

*/

internal class Program
    {
        static void Main(string[] args)
        {

      


        List <Array> arrayList= new List <Array> ();
        List <string> strList=new List<string> ();
        List<double> doubleList= new List <double> ();
        while (true)
        {

            Console.WriteLine("upisi: ");
            string a=Console.ReadLine ();
            if (a == " ") break;
            if (double.TryParse(a,out double broj)) { 
            doubleList.Add (broj);
            
            }
            else
            {
                strList.Add(a);
            }



        }
        Console.WriteLine("string lista: ");
        foreach (string s in strList) {

            Console.WriteLine(s);
        
        }
        Console.WriteLine("double lista: ");
        foreach (double d in doubleList) {
            Console.WriteLine(d);
        }

    }
}