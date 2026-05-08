/*

Load name and surname as one string with a space.
Write the name below as one string and the surname
as another according to the example. Use Length, Split
Insert. 
For example the string Pero Peric is loaded
P_e_r_o
P_e_r_i_c

*/

    internal class Program 

    { 

        static void Main(string[] args) 

        { 

            string a = Console.ReadLine(); 

            int l = a.IndexOf(' '); 

            string a1=a.Substring(0,l); 

            string a2=a.Substring(l+1); 

 

            char[] b1 = a1.ToCharArray(); 

            char[] b2 = a2.ToCharArray(); 

 

            string c1 = ""; 

            string c2 = ""; 

            for (int i = 0; i < a1.Length; i++) { 

                c1 =c1 + b1[i]; 

                if (i != a1.Length-1) c1 = c1 + "_"; 

            } 

            for (int i = 0; i < a2.Length; i++) 

            { 

                c2 = c2 + b2[i]; 

                if (i != a2.Length-1) c2 = c2 + "_"; 

            } 

 

            Console.WriteLine(c1); 

            Console.WriteLine(c2); 

 

        } 

    } 