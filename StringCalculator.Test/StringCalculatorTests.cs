using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Test
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("1,2", 3)]
        [TestCase("2,2", 4)]
        [TestCase("3,3,3", 9)]
        [TestCase ("1\n2,3", 6)]
        [TestCase("//;\n1;2", 3)]
        public void Add_Returns_Expected_Value(string input, int expected)
        {
            var calc = new StringCalculator();

            var result = calc.Add(input);

            Assert.That(result, Is.EqualTo(expected));
        }
        

        
    }
}
