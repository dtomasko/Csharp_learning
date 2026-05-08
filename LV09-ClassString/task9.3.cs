    /*
    
    Solve zask 9.2 without using methods of the string class.
    (Length property can be used)
    */
    internal class Program
{
    static void Main(string[] args)

{
    
    Console.WriteLine("upisi string: ");
            string a = Console.ReadLine();

            Console.WriteLine("upisi od kojeg do kojeg mjesta: ");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("upisi od kojeg do kojeg mjesta: ");
            int c = int.Parse(Console.ReadLine());

            char[] a1=new char[a.Length];
            string real = "";
            for (int i = 0; i < a.Length; i++) {


                a1[i] = (char)a[i];
            }
          for(int i = b-1; i < c; i++)
            {
                if (a1[i] >= 'a' && a1[i] <= 'z')
                {
                    a1[i] = (char)((int)a1[i] - 32);
                }
                    
            }
            for (int i = 0; i < a.Length; i++)
            {


               real+= a1[i];
            
            }
            Console.WriteLine(real);
        }
    }