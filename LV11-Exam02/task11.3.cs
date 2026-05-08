/*
Write a program in C# that asks for the input of three DateTime objects. Calculate the differences between all dates using TimeSpan. Write all the differences in order from least to greatest by writing
how many total minutes are in each TimeSpan.
*/
internal class Program
{
    private static void Main(string[] args)
    {

        DateTime[] datum=new DateTime[3];
        for (int i = 0; i < 3; i++) {
            Console.WriteLine($"upisi {i+1}. datum:");
            datum[i] =DateTime.Parse(Console.ReadLine());

        }
        TimeSpan[] razlika = new TimeSpan[6];
        razlika[0] = (datum[0] - datum[1]);
        razlika[1] = datum[0] - datum[2];
        razlika[2] = datum[1] - datum[0];
        razlika[3] = datum[1] - datum[2];
         razlika[4] = datum[2] - datum[1];
         razlika[5] = datum[2] - datum[0];
      Array.Sort( razlika );
        foreach (TimeSpan t in razlika) {
            Console.WriteLine($"{ t.TotalMinutes} minuta");
        }
      






    }
}
