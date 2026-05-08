
/*
Collecting points in the quiz.
The user plays a quiz with a task to collect 50 points.
Think of 10 questions that will be randomly choosen.
Request a answer to each question,
but the validation of the answer will be a radnom number of points
between 1 and 10. The program should use a `while` loop to ask question until
the user reaches required points. Finally, the program prints the total number of points 
*/


internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();

        string[] pitanja = {
            "Pitanje 1?", "Pitanje 2?", "Pitanje 3?", "Pitanje 4?", "Pitanje 5?",
            "Pitanje 6?", "Pitanje 7?", "Pitanje 8?", "Pitanje 9?", "Pitanje 10?"
        };

        int bodovi = 0;
        int brojPitanja = 0;

        while (bodovi < 50)
        {
            int index = rnd.Next(0, 10);

            Console.WriteLine(pitanja[index]);
            Console.Write("Odgovor: ");
            Console.ReadLine();

            int dobiveni = rnd.Next(1, 11);
            bodovi += dobiveni;
            brojPitanja++;

            Console.WriteLine($"Dobio si {dobiveni} bodova!\n");
        }

        Console.WriteLine($"Ukupno bodova: {bodovi}");
        Console.WriteLine($"Broj postavljenih pitanja: {brojPitanja}");
    }
}