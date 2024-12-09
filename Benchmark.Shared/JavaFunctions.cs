using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benchmark.Shared
{
    public class JavaFunctions
    {
        public void Sqrt(int candidate)
        {
            double value = candidate;
            Java.Lang.Math.Sqrt(value);
            Java.Lang.Math.Sqrt(value);
            Java.Lang.Math.Sqrt(value);
            Java.Lang.Math.Sqrt(value);
            Java.Lang.Math.Sqrt(value);
            Java.Lang.Math.Sqrt(value);
            Java.Lang.Math.Sqrt(value);
            Java.Lang.Math.Sqrt(value);
            Java.Lang.Math.Sqrt(value);
            Java.Lang.Math.Sqrt(value);
        }
    }
}
