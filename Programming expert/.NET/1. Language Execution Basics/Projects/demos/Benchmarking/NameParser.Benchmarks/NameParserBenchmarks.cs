using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using NameParserLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace NameParserLib.Benchmarks
{
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class NameParserBenchmarks
    {
        private const string FullName = "Steve J Gordon";
        private static readonly NameParser parser = new NameParser();

        [Benchmark(Baseline = true)]
        public void GetLastName()
        {
            parser.GetLastName(FullName);
        }

        [Benchmark]
        public void GetLastNameUsingSubstring()
        {
            parser.GetLastNameUsingSubstring(FullName);
        }

        [Benchmark]
        public void GetLastNameWithSpan()
        {
            parser.GetLastNameWithSpan(FullName);
        }
    }
}

