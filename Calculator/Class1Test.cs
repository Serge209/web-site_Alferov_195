using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator09;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clascalculator09s1.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void plusTest()
        {
            var calc = new Class1();
            string d = "+";
            int n1 = 2;
            int n2 = 6;

            int expected = 8;
            int result = calc.Plus(d, n1, n2);
            /*int actual = Class1.Plus(d, n1, n2);*/
            Assert.AreEqual(expected, result);


        }
    }
}
