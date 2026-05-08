/*
Calculation of monthly employee salaries
Write a program that stores the following information for an employee:
name (string), year (int), daily per hour (double), working hours (int) and tax percentage (float). 
The program should calculate the total post-tax salary and format printing to show the self-employed, 
the year, the working hours, the gross salary, the amount of taxes and the net salary, 
with the salaries of the formatted to 2 decimals.   
*/
internal class Program{
static void Main(string[] args)
    {

        Console.WriteLine("Unesite ime zaposlenika:");
        string ime = Console.ReadLine();

        Console.WriteLine("Unesite godine zaposlenika:");
        int god = int.Parse(Console.ReadLine());

        Console.WriteLine("Unesite bruto plaću po satu:");
        double brutoposatu = double.Parse(Console.ReadLine());

        Console.WriteLine("Unesite broj radnih sati:");
        int brsati = int.Parse(Console.ReadLine());

        Console.WriteLine("Unesite porezni postotak:");
        float porezpostotak = float.Parse(Console.ReadLine());

        Console.WriteLine($"Ime: {ime}, godine: {god}, broj odradenih sati: {brsati}, bruto placa: {(brutoposatu*brsati):F2}, iznos poreza: {((brutoposatu * brsati)*(porezpostotak/100)):F2}, neto placa: {((brutoposatu * brsati) - ((brutoposatu * brsati) * (porezpostotak / 100))):F2}");
    }
}
