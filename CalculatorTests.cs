using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UniTestApp
{
    public class CalculatorTests
    {
        [Fact]
        public static void SimpleTest()
        {
            var result = Calculator.CalculateSum("3,8,4,2,7");
            Assert.Equal(24, result);
        }

        [Fact]
        public static void TestWith10()
        {
            var result = Calculator.CalculateSum("3,8,4,2,12");
            Assert.Equal(17, result);
        }

        [Fact]
        public static void OnlyFirst5Test()
        {
            var result = Calculator.CalculateSum("3,8,4,2,7,1,5");
            Assert.Equal(24, result);
        }

        [Fact]
        public static void NegativeTest()
        {
            var result = Calculator.CalculateSum("3,8,-4,2,7");
            Assert.Equal(0, result);
        }

        [Fact]
        public static void DelimiterTest()
        {
            var result = Calculator.CalculateSum("3|8|4|2|7", '|');
            Assert.Equal(24, result);
        }

        [Fact]
        public static void NonNumeralTest()
        {
            Assert.Throws<Exception>(() => Calculator.CalculateSum("3,8,4,a,7"));
        }

        [Fact]
        public static void TestWithNothing()
        {
            var result = Calculator.CalculateSum("");
            Assert.Equal(0, result);
        }
    }
}
