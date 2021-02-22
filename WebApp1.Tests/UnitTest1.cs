using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication2.utilities;
namespace WebApp1.Tests
{
    [TestClass]
    public class SavingTests
    {
        [TestMethod]
        public void Interest()
        {//arrange
            decimal principal = 10000;
            decimal rate = 5;
            decimal time = 1;
            decimal sum = 10500;
            //act
            var save = new Savings();
            var mySum = save.InterestCalculator(principal, rate, time);
            //Assert
            Assert.AreEqual(sum, mySum);


        }

    }
}
