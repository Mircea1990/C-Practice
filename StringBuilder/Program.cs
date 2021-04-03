using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilderTest

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("##String Builder Performance");

            const int noOfRepetition = 96666;
            var regularString = string.Empty; /* "" */

            var watch = Stopwatch.StartNew();
            for(var i = 0; i < noOfRepetition; i++)
            {
                regularString += "a";
            }
            watch.Stop();
            var elaptedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Using regular string: {0} ms", elaptedMs);

            Console.WriteLine();

            StringBuilder sb = new StringBuilder();
            var watch2 = Stopwatch.StartNew();
            for(var i = 0; i<noOfRepetition; i++)
            {
                sb.Append("a");
            }
            regularString = sb.ToString();
            watch2.Stop();
            elaptedMs = watch2.ElapsedMilliseconds;
            Console.WriteLine("Using StringBuilder: {0} ms", elaptedMs);

            Console.ReadLine();

        }
    }
}
