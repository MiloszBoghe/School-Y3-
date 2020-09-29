using System;
using System.Diagnostics;

namespace NameParserLib
{
    class Program
    {
        private const string FullName = "Steve J Gordon";
        private static readonly NameParser parser = new NameParser();

        static void Main(string[] args)
        {
            Console.WriteLine("Naive benchmark");

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            parser.GetLastName(FullName);
            stopwatch.Stop();
            Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Elapsed time: {stopwatch.ElapsedTicks} ticks");
        }
    }
}
