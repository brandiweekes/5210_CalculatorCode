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
    public class CompoundInterestCalculatorUnitTests
    {
        [Test]
        public void CompIntCalc_valid_input_should_pass()
        {
            //Arrange
            var model = new CalculatorCode.Models.CompoundInterestCalculator();
            model.PrincipalInput = 1000.00;
            model.InterestRateInput = 5.00;
            model.TimeInYears = 10.00;
            model.CompoundFrequencyPerYear = 12;

            double expected = 1647.0094976902801d;

            //Act
            model.TotalAccrued = model.CalculateAccruedAmount();
            var actual = model.TotalAccrued;

            //Assert note that Checking only for days accuracy
            Assert.AreEqual(actual, expected, "Some useful error message");

            //Reset NA
        }
    }
}
