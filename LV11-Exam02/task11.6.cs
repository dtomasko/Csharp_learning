/*

Write a program in C# in which you will define the following two variables of type string:
• s1 with the content "Croatia has a sea"
• s2 with the content "Italy is the world champion"
Define and print the string s3 whose content will be the first 8 characters of the string s1 plus all characters from
seventh to the end of the sequence s2. Make sure to use String class methods.
*/

 
 internal class program{
 private static void Main(string[] args)
    {
        string s1 = "Hrvatska ima more";
        string s2 = "Italija je prvak svijeta";

        string s3 = s1.Substring(0, 8) + s2.Substring(7, s2.Length-7);
        Console.WriteLine(s3);
       
    }
}

