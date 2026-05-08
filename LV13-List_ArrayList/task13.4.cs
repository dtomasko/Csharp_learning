/*

Write a program that will define a list that will contain the first n two-digit numbers
numbers. Ask the user to enter the number n, and force him not to enter a number greater than the maximum number
number of two-digit numbers. Print the list.
*/


internal class Program
{
    private static void Main(string[] args)
    {

        List<int> intList = new List<int>();

        Console.WriteLine("upisi koliko br zelis");
        int n = int.Parse(Console.ReadLine());
        if (n <= 90)
        {
            for (int i = 10; i < n+10; i++)
            {
                intList.Add(i);
            }
            foreach (int a in intList)
            {
                Console.WriteLine(a);
            }
        }
        else Console.WriteLine("pogresan upis");

    }
}