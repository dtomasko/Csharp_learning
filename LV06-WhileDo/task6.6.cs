
/*
User input validation
Create a program that asks users to enter PIN to access the account.
Make PIN as a constant. PIN must be a four-digit number.
It uses `do...while` loop to allow input until the user enters the correct PIN. 
Each time a wrong PIN is entered, the program prints a message.
*/
class Program
{
    static void Main(string[] args)
    {
        string pin = "1234";
        string pin1;
        do
        {
            Console.Write("Unesite PIN: ");
            pin1 = Console.ReadLine();
            if (pin1 != pin)
            {
                Console.WriteLine("Upisan je krivi pin.");
                Console.Write("Unesite PIN: ");
                pin1 = Console.ReadLine();
            }
            
        } while (pin1!=pin);
        Console.WriteLine("Upisan je pravi PIN.");
}
}