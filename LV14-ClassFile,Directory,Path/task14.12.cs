
/*

Write a program that will protect the contents of a text file with the simple encryption algorithm Rot13 
and save it to another file.
Search the Internet for the Rot13 algorithm and how does it work.
*/


internal class Program
    {
        static void Main(string[] args)
        {
        string path = @"C:\Users\Dominik\Desktop\1.txt";
        string path2 = @"C:\Users\Dominik\Desktop\2.txt";
        string text = File.ReadAllText(path);

        string result = Rot13(text);
        File.WriteAllText(path2, result);
    }

    static string Rot13(string text) {


        char[] a= text.ToCharArray();

        for (int i = 0; i < a.Length; i++)
        {
            char c = a[i];
            if (c >= 'a' && c <= 'z')
            {
                a[i] = (char)((c - 'a' + 13) % 26 + 'a');
            }
            
            else if (c >= 'A' && c <= 'Z')
            {
                a[i] = (char)((c - 'A' + 13) % 26 + 'A');
            }
        }
        return new string (a);

    }

}
