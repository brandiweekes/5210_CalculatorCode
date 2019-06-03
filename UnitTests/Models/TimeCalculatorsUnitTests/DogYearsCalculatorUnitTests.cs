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
    public class DogYearsCalculatorUnitTests
    {
        [Test]
        public void DogYearsCalc_valid_input_should_pass()
        {
            //Arrange
            var model = new CalculatorCode.Models.DogYearsCalculator();
            model.InputOne = 13;
            var expected = model.InputOne * 7;

            //Act
            var actual = model.CalculateResult();

            //Assert note that Checking only for days accuracy
            Assert.AreEqual(actual, expected, "Some useful error message");
        }

        [Test]
        public void DogYearCalc_valid_input_neg_year_should_pass()
        {
            //Arrange
            var model = new CalculatorCode.Models.DogYearsCalculator();
            model.InputOne = -9;
            var expected = model.InputOne * 7;

            //Act
            var actual = model.CalculateResult();

            //Assert note that Checking only for days accuracy
            Assert.AreEqual(actual, expected, "Some useful error message");
        }
    }
}
