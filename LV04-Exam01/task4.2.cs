
/*

The task is to enable Ana to enter the item name (data type: string)
and grades (data type: double). The program should print each item and its grade in the format:
"Subject: [name], Rating: [assessment – on two decimals (f format selector).] ",
and an average assessment of all items formatted in 2 decimal places
“The average rating of all items is: [average rating – on two decimals (f format selector).] “.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        String[] predmet = new string[3];
        double[] ocj = new double[3];
        double zbr = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"upisi naziv predmeta {i + 1}. :");
            predmet[i] = Console.ReadLine();
            Console.WriteLine($"upisi ocjenu za {i + 1}. predmet: ");
            ocj[i] = Convert.ToDouble(Console.ReadLine());
            zbr += ocj[i];
        }
        double ar = (double)zbr / 3;
        for (int j = 0; j < 3; j++)
        {
            Console.WriteLine($"Predmet: {predmet[j]}, ocjena: {ocj[j]:F2}\n");
        }
        Console.WriteLine($"prosjecna ocjena: {ar:F2}");
    }
}
