using System;

namespace Working_with_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            string s1 = "abc";
            string s2 = s1;
            Console.WriteLine(s1);
            s1 = s1.Replace("abc", "xz");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();

            //Ex2
            string s3 = "kmn";
            string s4 = s3;
            s3 += "d";
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }
    }
}
