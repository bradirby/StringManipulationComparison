using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulationComparison
{
    /// <summary>
    /// Testing Note
    ///  - strings are added to a list in order to prevent the compiler from optimizing out all logic to build the string (which would be unused)
    /// </summary>
    public class ComparisonsAddingToList
    {

        public long  StringInterpolation(int numOps)
        {
            string s;
            var rnd = new Random();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var lst = new List<string>();
            for (int n = 0; n < numOps; n++)
            {
                s = $"this is an int{rnd.Next(100)} this is a string {Guid.NewGuid().ToString()} and this is a date {DateTime.Now}";
                lst.Add(s);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long StringBuilder(int numOps)
        {
            string s;
            var rnd = new Random();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var lst = new List<string>();
            var sb = new StringBuilder();
            for (int n = 0; n < numOps; n++)
            {
                sb.Clear();
                sb.Append("this is an int");
                sb.Append(rnd.Next(100).ToString());
                sb.Append("this is a string ");
                sb.Append(Guid.NewGuid());
                sb.Append(" and this is a date ");
                sb.Append(DateTime.Now);
                s = sb.ToString();
                lst.Add(s);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long StringFormat(int numOps)
        {
            string s;
            var rnd = new Random();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var lst = new List<string>();
            for (int n = 0; n < numOps; n++)
            {
                s = String.Format("this is an int{0} this is a string {1} and this is a date {2}", rnd.Next(100), Guid.NewGuid().ToString(), DateTime.Now);
                lst.Add(s);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long StringAdd(int numOps)
        {
            string s;
            var rnd = new Random();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var lst = new List<string>();
            for (int n = 0; n < numOps; n++)
            {
                s = "this is an int";
                s += rnd.Next(100).ToString();
                s += "this is a string ";
                s += Guid.NewGuid().ToString();
                s += " and this is a date ";
                s += DateTime.Now;
                lst.Add(s);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }

        public long StringConcat(int numOps)
        {
            string s;
            var rnd = new Random();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var lst = new List<string>();
            for (int n = 0; n < numOps; n++)
            {
                string[] sArr =
                {
                    "this is an int",
                    rnd.Next(100).ToString(),
                    "this is a string ",
                    Guid.NewGuid().ToString(),
                    " and this is a date ",
                    DateTime.Now.ToString()
                };

                s = string.Concat(sArr);
                lst.Add(s);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }
    }
}
