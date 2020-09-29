using BenchmarkDotNet.Running;
using NameParserLib.Benchmarks;
using System;

namespace NameParser.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<NameParserBenchmarks>();
        }
    }
}
