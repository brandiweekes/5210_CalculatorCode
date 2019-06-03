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
    public class AgeCalculatorUnitTests
    {
        [Test]
        public void AgeCalc_valid_input_should_pass()
        {
            //Arrange
            var model = new CalculatorCode.Models.AgeCalculator();
            DateTime BirthDate = new DateTime(2008, 3, 28, 0, 0, 0);
            model.InputOne = BirthDate;
            TimeSpan expected = DateTime.Now - model.InputOne;

            //Act
            var actual = model.CalculateAge();
            
            //Assert note that Checking only for days accuracy
            Assert.AreEqual(actual.Days, expected.Days, "Some useful error message");
            
            //Reset NA
        }

        [Test]
        public void AgeCalc_valid_input_year_in_future_should_pass()
        {
            //Arrange
            var model = new CalculatorCode.Models.AgeCalculator();
            DateTime BirthDate = new DateTime(2028, 3, 28, 0, 0, 0);
            model.InputOne = BirthDate;
            TimeSpan expected = DateTime.Now - model.InputOne;

            //Act
            var actual = model.CalculateAge();

            //Assert note that Checking only for days accuracy
            Assert.AreEqual(actual.Days, expected.Days, "Some useful error message");
        }
    }
}
