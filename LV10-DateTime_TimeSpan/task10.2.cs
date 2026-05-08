/*

Write a program that loads the date of birth, 
and prints how old the person is,
but in days and months. (It does not use the TimeSpan structure.)

*/

 internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("upsii datum rodjenja: ");
            DateTime datum = DateTime.Parse(Console.ReadLine());

            DateTime danas = DateTime.Now;


            long razlika = danas.Ticks - datum.Ticks;
          
            long a = razlika / (24L * 60 * 60 * 10000000);
            long mjeseci = a / 30;
            long dani = a % 30;
            Console.WriteLine($"osoba je stara mjeseci: {mjeseci} i dana; {dani}");


        }
    }
