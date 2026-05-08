
    /*
    Declare a complete constant and assign it a value of 3
    then declare a decimal variable and give it a value of 2.3.
    Then load a new decimal number and change the value of the variable to that number.
    Then print the sum, multiplication and substitution values of the variable together
    with the header tab, as on the example. 
    EXAMPLE: 
    a x a+x a*x a/x 
    3 2.3 5.3 6.9 1.304 
    3 1.2 4.2 3.6 2.5
    
    
    */
    
    
    internal class Program
    {
    static void Main(string[] args)
    {

        int a = 3;
        double x = 2.3;
        Console.WriteLine("upisi dec broj: ");
        double b=double.Parse(Console.ReadLine());
        
        Console.WriteLine("a\tx\ta+x\ta*x\ta/x");
        Console.WriteLine($"{a}\t{x}\t{a + x}\t{(a * x):F2}\t{(a / x):F2}");
        Console.WriteLine($"{a}\t{b}\t{a + b}\t{(a * b):F2}\t{(a / b):F2}");
    }
}
