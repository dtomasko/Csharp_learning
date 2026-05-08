/*

Write a program that will define a list of type string, and will define another list of type int
in which the members will be the lengths of the strings from the first array. 
The program must work properly for arbitrary number of list members. 
Prompt the user to enter list elements until they enter a number.
Print the lists.
*/

internal class Program
{
    private static void Main(string[] args)
    {

        List<string >strList = new List<string>();
        List<int> intList = new List<int>();

        while (true) {
            Console.WriteLine("upisi str: ");
            string a= Console.ReadLine();
            if (int.TryParse(a, out int broj)){
                Console.WriteLine("kraj");
                break;


            }
            strList.Add(a);
            intList.Add(a.Length);
        }
        foreach (string s in strList) { 
        Console.WriteLine(s);
        }
        foreach (int i in intList)
        {
            Console.WriteLine(i);
        }
    }
}