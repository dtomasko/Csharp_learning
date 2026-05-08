/*
Write a program that will store the multiplication table
in a two-dimensional field (use column and row multiplication).
Print the table.

*/

class Program
{
    static void Main()
    {
        int[,] tablica = new int[10, 10];
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                tablica[i, j] = (i+1)*(j+1);

            }
        }

        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) { 
                Console.Write(tablica[i, j]+"\t");
            }
            Console.WriteLine();
        }
    }
}