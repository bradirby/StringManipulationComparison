using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StringManipulationComparison
{
    /// <summary>
    /// Testing Note
    ///  - strings are added to a list in order to prevent the compiler from optimizing out all logic to build the string (which would be unused)
    /// </summary>
    public class Comparisons
    {

        public long  StringInterpolation(int numOps)
        {
            string s;
            var p1 = "1";
            var p2 = "2";
            var stopwatchConcat2 = Stopwatch.StartNew();
            for (var i = 0; i < numOps; i++)
                s = $"{p1} {p2}";
            stopwatchConcat2.Stop();
            return stopwatchConcat2.ElapsedMilliseconds;
        }

        public long StringBuilder(int numOps)
        {
            string s;
            var stopwatchConcat2 = Stopwatch.StartNew();
            var theBuilder = new StringBuilder();
            for (var i = 0; i < numOps; i++)
            {
                theBuilder.Clear();
                theBuilder.Append("1 2");
                s = theBuilder.ToString();
            }

            stopwatchConcat2.Stop();
            return stopwatchConcat2.ElapsedMilliseconds;

        }

        public long StringFormat(int numOps)
        {
            string s;
            var stopwatchConcat2 = Stopwatch.StartNew();
            for (var i = 0; i < numOps; i++)
                s = String.Format("{0},{1}",1,2);
            stopwatchConcat2.Stop();
            return stopwatchConcat2.ElapsedMilliseconds;
        }

        public long StringAdd(int numOps)
        {
            string s;
            var stopwatchConcat2 = Stopwatch.StartNew();
            for (var i = 0; i < numOps; i++)
                s = "1" + "2";
            stopwatchConcat2.Stop();
            return stopwatchConcat2.ElapsedMilliseconds;
        }

        public long StringConcat(int numOps)
        {
            string s;
            var stopwatchConcat2 = Stopwatch.StartNew();
            for (var i = 0; i < numOps; i++)
                s = String.Concat("1", "2");
            stopwatchConcat2.Stop();
            return stopwatchConcat2.ElapsedMilliseconds;
        }
    }
}
