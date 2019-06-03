using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorCode.Models;

namespace UnitTests.Models
{
    [TestFixture]
    public class SimpleInterestCalculatorUnitTests
    {
        [Test]
        public void SimpleIntCalc_valid_input_should_pass()
        {
            //Arrange
            var model = new CalculatorCode.Models.SimpleInterestCalculator();
            model.PrincipalInput = 1000.00;
            model.InterestRateInput = 10.00;
            model.TimeInYears = 5.00;
            Double expected = 1500.00;

            //Act
            model.TotalAccrued = model.CalculateAccruedAmount();
            var actual = model.TotalAccrued;

            //Assert note that Checking only for days accuracy
            Assert.AreEqual(actual, expected, "Some useful error message");

            //Reset NA
        }
    }
}
