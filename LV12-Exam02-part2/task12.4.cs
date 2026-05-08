  //Write a program in C# that, for a date entered from the keyboard, prints the dates of all Tuesdays of the month.
  
  internal class prgram{

    private static void Main(string [] args){
  Console.WriteLine("upisi datum");
        DateTime a = DateTime.Parse(Console.ReadLine());
        int b = a.Month;

        while (a.Month==b) {
            if (a.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine($"datum utorka: {a}");

            }
            a = a.AddDays(1);
            
                
            }

        }
    } 