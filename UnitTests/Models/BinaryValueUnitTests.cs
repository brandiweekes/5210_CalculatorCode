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
    public class BinaryValueUnitTests
    {
        [Test]
        public void BinaryValue_SumInBinaryFromStrings_inputOne_11111111_inputTwo_00000000_should_return_valid_binary()
        {
            // Arrange
            
            var inputOne = "11111111";
            var inputTwo = "00000000";
            var expectedBinary = "11111111";

            // Act
            var actualBinary = BinaryValue.SumInBinaryFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedBinary, actualBinary, "converting addition to binary: 11111111");
        }

        [Test]
        public void BinaryValue_SumInDecimalFromStrings_inputOne_11111111_inputTwo_00000000_should_return_valid_decimal()
        {
            // Arrange

            var inputOne = "11111111";
            var inputTwo = "00000000";
            var expectedDecimal = 255;

            // Act
            var actualDecimal = BinaryValue.SumInDecimalFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedDecimal, actualDecimal, "converting addition to decimal: 255");
        }

        [Test]
        public void BinaryValue_SumInBinary_inputOne_11111111_inputTwo_00000000_should_return_valid_binary()
        {
            // Arrange

            var inputOne = new BinaryValue("11111111");
            var inputTwo = new BinaryValue("00000000");
            var expectedBinary = "11111111";

            // Act
            var actualBinary = BinaryValue.SumInBinary(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedBinary, actualBinary, "converting addition to binary: 11111111");
        }

        [Test]
        public void BinaryValue_SumInDecimal_inputOne_11111111_inputTwo_00000000_should_return_valid_decimal()
        {
            // Arrange

            var inputOne = new BinaryValue("11111111");
            var inputTwo = new BinaryValue("00000000");
            var expectedDecimal = 255;

            // Act
            var actualDecimal = BinaryValue.SumInDecimal(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedDecimal, actualDecimal, "converting addition to decimal: 255");
        }
    }
}
