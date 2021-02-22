using System;
using WebApplication2.utilities;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {


        [Theory]
        [InlineData(10000, 5, 1, 10500)]
        [InlineData(1, 0, 1, 1)]
        [InlineData(-20000, -100, 1, 0)]
        [InlineData(20000, 2.5, 1, 20500)]
        public void Test2(decimal principal, decimal rate, decimal time, decimal sum)
        {
            var save = new Savings();
            var mySum = save.InterestCalculator(principal, rate, time);
            Assert.Equal(sum,mySum);
        }
    }
}
