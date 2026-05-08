
/*
The task is to enable John to enter the name of the movie(data type: string) 
and the duration of the film in minutes (data type: int). 
The program should print the name of the film and the duration in the format:
"Film: [film name], Duration: [number of minutes – with a minimum of 2 digits (format selector: d)] min."
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("upisi ime filma: ");
        string ime = Console.ReadLine();
        Console.WriteLine("upisi trajanje u min: ");
        int trajanje = int.Parse(Console.ReadLine());
        Console.WriteLine($"Film: {ime}, trajanje: {trajanje:D2} min");
       
    }
}
