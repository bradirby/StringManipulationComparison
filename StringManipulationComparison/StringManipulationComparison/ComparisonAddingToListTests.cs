﻿using System;
using System.Diagnostics;
using NUnit.Framework;

namespace StringManipulationComparison
{
    public class ComparisonAddingToListTests
    {
        private int numTimesToRun = 1000000;

        [Test]
        public void TestStringInterpolation()
        {
            var sut = new ComparisonsAddingToList();
            var execTime = sut.StringInterpolation(numTimesToRun);
            Console.WriteLine($"StringInterpolation {execTime} ms");
        }

        [Test]
        public void TestStringAdd()
        {
            var sut = new ComparisonsAddingToList();
            var execTime = sut.StringAdd(numTimesToRun);
            Console.WriteLine($"StringAdd {execTime} ms");
        }

        [Test]
        public void TestStringConcat()
        {
            var sut = new ComparisonsAddingToList();
            var execTime = sut.StringConcat(numTimesToRun);
            Console.WriteLine($"StringConcat {execTime} ms");
        }


        [Test]
        public void TestStringBuilder()
        {
            var sut = new ComparisonsAddingToList();
            var execTime = sut.StringBuilder(numTimesToRun);
            Console.WriteLine($"StringBuilder {execTime} ms");
        }

        [Test]
        public void TestStringFormat()
        {
            var sut = new ComparisonsAddingToList();
            var execTime = sut.StringFormat(numTimesToRun);
            Console.WriteLine($"StringFormat {execTime} ms");
        }
    }
}
