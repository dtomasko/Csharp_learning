/*

Write a program that enters the working time (h:m:s)
of the person on the project for each day,the project lasted 3 days.
The total working time should be printed in hours, minutes and seconds,
h:m:s. (Uses a loop to write and a TimeSpan structure)
*/

 internal class Program
    {
        static void Main(string[] args)
        {
            DateTime[] polje= new DateTime[3];
            TimeSpan ukupno=TimeSpan.Zero;
            for (int i = 0; i < 3; i++) {
                Console.WriteLine($"upisi {i+1}. rando vrijeme: ");
                polje[i] = DateTime.Parse(Console.ReadLine());
                ukupno += polje[i].TimeOfDay;
            }
            Console.WriteLine($"Ukupno rando vrijeme u satima: {ukupno.TotalHours}, u minutama: {ukupno.TotalMinutes}, u sekundama {ukupno.TotalSeconds}");

        }
    }
