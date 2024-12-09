using Android.Util;
using Kotlin.Jvm.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Benchmark
{
    internal class BenchmarkCreator
    {
        public static void Create(string name, Action<int> toPerform, int repetitions)
        {
            List<double> times = new List<double>(repetitions);

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i<repetitions; i++)
            {
                sw.Reset();
                sw.Start();
                toPerform(i);
                sw.Stop();
                
                times.Add(sw.Elapsed.TotalMilliseconds * 1000);              
            }

            double average = times.Sum()/repetitions;
            double variance = 0;
            times.ForEach(x => variance += Math.Pow(x - average, 2));
            variance /= repetitions;
            var stdDev = Math.Sqrt(variance);
            Log.Info("Benchmark", $"{name}:\tmin={times.Min()} µs\tavg={average} µs\tmax={times.Max()} µs\tstdDev={stdDev} µs");
        }
    }
}
