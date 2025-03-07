using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace UnitTesting.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        Program program = new Program();
        [TestMethod()]
        public void addTest()
        {
            int expected = 3;
            int actual = program.add(1, 2);
            Debug.WriteLine($"Expected: {expected}, Actual {actual}");
            Assert.AreEqual(expected, actual, "The add method did not return the expected result");
        }
    }
}