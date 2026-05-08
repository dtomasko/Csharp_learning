/*
Write a program that checks the number of open and closed parentheses.
If there is an excess of open parentheses, the program deletes them starting
from the left, and if there is an excess of closed parentheses from the right.
We understand the connection of the round building. 
At the end, join the string without empty spaces and print it, 
and then using the methods of the String class: IndexOf, Replace, Remove.

*/

   internal class Program 

    { 

        static void Main(string[] args) 

        { 

            string a = Console.ReadLine(); 

             

            char[] a1 = a.ToCharArray(); 

 

            int z = 0; 

            int o = 0; 

            for (int i = 0; i < a1.Length; i++) { 

                if (a1[i] == '(') o++; 

                if (a1[i] == ')') z++; 

 

            } 

            if (o > z) 

            { 

                int b = o - z; 

                for (int i = 0; i < b; i++) 

                { 

                    int l = a.IndexOf(")"); 

                    a = a.Remove(l, 1); 

                } 

 

            } 

            else if (o < z) 

            { 

                int b = z-o; 

                for(int i=0; i<b; i++) { 

                    int l = a.IndexOf(")"); 

                    a = a.Remove(l, 1); 

                } 

                 

            } 

            Console.WriteLine(a); 

 

        } 

    }