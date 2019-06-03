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
    public class TimeCalculatorUnitTests
    {
        [Test]
        public void TimeCalc_valid_input_InputTwoGreaterThanInputOne_should_pass()
        {
            //Arrange
            var model = new CalculatorCode.Models.TimeCalculatorModel();
            model.InputOne = new DateTime(2008, 3, 28, 0, 0, 0);
            model.InputTwo = new DateTime(2018, 3, 28, 0, 0, 0);

            //mocking the if condition in the controller
            TimeSpan expected = model.InputTwo- model.InputOne;

            //Act
            var actual = model.CalculateTimeSpanResult();

            //Assert note that Checking only for days accuracy
            Assert.AreEqual(actual.Days, expected.Days, "Some useful error message");
        }

        [Test]
        public void TimeCalc_valid_input_InputOneGreaterThanInputTwo_should_pass()
        {
            //Arrange
            var model = new CalculatorCode.Models.TimeCalculatorModel();
            model.InputOne = new DateTime(2018, 3, 28, 0, 0, 0);
            model.InputTwo = new DateTime(2008, 3, 28, 0, 0, 0);

            //mocking the if condition in the controller
            TimeSpan expected = model.InputOne - model.InputTwo;

            //Act
            model.Result = model.CalculateResultReverse();
            var actual = model.Result;

            //Assert note that Checking only for days accuracy
            Assert.AreEqual(actual.Days, expected.Days, "Some useful error message");
        }

    }
}
