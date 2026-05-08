/*

Write a program that, for a defined list of type int, will check if they are in the list
at least two of the same members. Ask the user to enter the elements of the list until they enter a real number.
Print the list and repeating members.
*/

using System.Runtime.Serialization.Json;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {

        List<int> intList = new List<int>();
        while (true)
        {
            Console.WriteLine("upisi br");
          string a=Console.ReadLine();
            if(!int.TryParse(a,out int broj))
            {
                Console.WriteLine("kraj");
                break;
            }
            else { intList.Add(broj); }
            

        }
        foreach(int i in intList)
        {

        Console.WriteLine(i); }
        for(int i = 1; i < intList.Count; i++)
        {
            if (intList[i] == intList[i -1]) { Console.WriteLine($"PONAVLJA SE: {intList[i]}"); }


        }
    }
}