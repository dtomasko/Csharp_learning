
/*
Marko wants a program that will allow data to be entered for 3 destinations in 3 sets of diffrent data types,
then format the printing of all destinations entered and calculate the average rating of all destinations.
The task is to enable the entry of three data types: string[3], int[3], and double[3]. 
The program should print each destination in format:
"Destination: [City name], Days: [number of days], Rating: [assessment]"
Also, a method should be implemented: calculating the average rating of all destinations, and printing
average rating of all destinations.

*/

internal class Program
{
    private static void Main(string[] args)
    {
        String[] naziv = new string[3];
        int[] brdana = new int[3];
        double[] ocj = new double[3];
        double zbr = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"upisi naziv {i + 1}. grada");
            naziv[i] = Console.ReadLine();
            Console.WriteLine($"upisi broj dana {i + 1}. grada");
            brdana[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"upisi ocjenu  {i + 1}.  grada");
            ocj[i] = Double.Parse(Console.ReadLine());
            
        }
        for (int j = 0; j < 3; j++)
        {
Console.WriteLine($"Odredište: {naziv[j]}, Dani: {brdana[j]}, Ocjena: {ocj[j]}");
        }

        Console.WriteLine($"\nProsječna ocjena svih odredišta: {prosjek(ocj,zbr):F2}");
        
        
        static double prosjek(double[] ocj, double zbr)
        {
            for (int i = 0; i < 3; i++)zbr += ocj[i];
            return zbr / 3;
        }
    }
}
