
/*
Student rating storage table
Write a program that saves grades from 3 subjects for 5 students 
(grades are int values). Also, for each student there should be a bool if he passed or not.
Print data in the form of a table like the example. 
Grades should be displayed as numbers between 1 i 5, 
For example:
| Name | Math | Fiz | Kem | Passage |
| Ivan  |  4  |  5  |  3  |  True  |
| Ana   |  2  |  3  |  2  |  False  |

*/
internal class Program
{
    private static void Main(string[] args)
    {
        string[] ime = new string[5];
        byte[] mat = new byte[5];
        byte[] fiz = new byte[5];
        byte[] kem = new byte[5];
        bool[] prolaz= new bool[5];
        for (int i = 0; i < 5; i++)
        {
            
            Console.WriteLine($"upisi ime za {i+1}. ucenika: ");
            ime[i] = Console.ReadLine();
            Console.WriteLine($"upisi ocj mat {i+1}. ucenika: ");
            mat[i]=byte.Parse(Console.ReadLine());
            Console.WriteLine($"upisi ocj fiz {i+1}. ucenika: ");
            fiz[i] = byte.Parse(Console.ReadLine());
            Console.WriteLine($"upisi ocj kem {i + 1}. ucenika: ");
            kem[i] = byte.Parse(Console.ReadLine());
            if (mat[i] > 1 && fiz[i] > 1 && kem[i] > 1)prolaz[i] = true;
            else prolaz[i] = false;
            
        




    }
        Console.WriteLine("|IME|MAT|FIZ|KEM|PROLAZ|");
        for (int j = 0; j < 5; j++)
        {
            Console.WriteLine($"|{ime[j]}|{mat[j]}|{fiz[j]}|{kem[j]}|{prolaz[j]}");
        }

    }
   
}
