
/*

Password creation
Write a program that receives the user's password entry as a array of characters (char[]) 
and checks whether the password completes the following conditions: 
minimum 8 characters, contains a atleast 1 small and a one capital letter (bool).
Then print the result in the shape of the table where the conditions are displayed as (bool). 
For example:
| Condition | Filled |
| Minimum 8 characters | True |
| Contains number | True |
| Contains large letter | False |

*/

internal class Program
{
    private static void Main(string[] args)
    {
        char[] loz = new char[100];
        bool min8znak;
        bool imaBroj=false;
        bool imaslovo=false;
        Console.WriteLine("upisi lozinku: ");
        string lozinka=Console.ReadLine();
        for(int i = 0; i < lozinka.Length; i++)
        {
            loz[i]=Convert.ToChar(lozinka[i]);
            if (loz[i] >= '0' && loz[i] <= '9')imaBroj=true;
        
            if ((loz[i] >= 'A' && loz[i] <= 'Z')|| (loz[i] >= 'a' && loz[i] <= 'z')) imaslovo = true;
            
            

        }
        if (lozinka.Length >= 8) min8znak = true;
        else min8znak = false;
        Console.WriteLine("|Uvjet       |Ispunjeno|");
        Console.WriteLine($"|min 8 znakova|{min8znak}");
        Console.WriteLine($"|ima br|{imaBroj}");
        Console.WriteLine($"|ime slovo|{imaslovo}");
        
        






    }
   
}