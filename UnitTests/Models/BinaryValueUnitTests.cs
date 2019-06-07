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
        #region Sum
        /// <summary>
        /// given two valid binary strings, should return valid decimal sum
        /// </summary>
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

        /// <summary>
        /// given two valid binary strings, should return valid binary sum
        /// </summary>
        [Test]
        public void BinaryValue_SumInBinaryFromStrings_inputOne_1111111111111111111111111111111_inputTwo_1_should_return_valid_binary()
        {
            // Arrange
            var inputOne = "1111111111111111111111111111111";
            var inputTwo = "1";
            var expectedBinary = "10000000000000000000000000000000";

            // Act
            var actualBinary = BinaryValue.SumInBinaryFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedBinary, actualBinary, "converting addition to binary: 10000000000000000000000000000000");
        }

        /// <summary>
        /// given valid input binary strings, should return valid decimal sum
        /// </summary>
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

        /// <summary>
        /// given valid input binary strings, should return valid decimal sum
        /// checks for handling sum = max int32
        /// </summary>
        [Test]
        public void BinaryValue_SumInDecimalFromStrings_inputOne_1111111111111111111111111111111_inputTwo_1_should_return_valid_binary()
        {
            // Arrange
            var inputOne = "1111111111111111111111111111111";
            var inputTwo = "1";
            var expectedDecimal = "2147483648";

            // Act
            var actualDecimal = BinaryValue.SumInDecimalFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedDecimal, actualDecimal, "converting addition to binary: 2147483648");
        }

        /// <summary>
        /// given valid input binary strings, should return valid binary sum
        /// </summary>
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

        /// <summary>
        /// given valid input binary strings, should return valid binary sum
        /// checks for handling sum = max int32
        /// </summary>
        [Test]
        public void BinaryValue_SumInBinary_inputOne_1111111111111111111111111111111_inputTwo_1_should_return_valid_binary()
        {
            // Arrange
            var inputOne = new BinaryValue("1111111111111111111111111111111");
            var inputTwo = new BinaryValue("1");
            var expectedBinary = "10000000000000000000000000000000";

            // Act
            var actualBinary = BinaryValue.SumInBinary(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedBinary, actualBinary, "converting addition to binary: 10000000000000000000000000000000");
        }

        /// <summary>
        /// given valid input binary strings, should return valid decimal sum
        /// </summary>
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

        /// <summary>
        /// given valid input binary strings, should return valid decimal sum
        /// checks for handling sum = max int32
        /// </summary>
        [Test]
        public void BinaryValue_SumInDecimal_inputOne_1111111111111111111111111111111_inputTwo_1_should_return_valid_decimal()
        {
            // Arrange
            var inputOne = new BinaryValue("1111111111111111111111111111111");
            var inputTwo = new BinaryValue("1");
            var expectedDecimal = 2147483648;

            // Act
            var actualDecimal = BinaryValue.SumInDecimal(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedDecimal, actualDecimal, "converting addition to decimal: 2147483648");
        }
        #endregion

        #region Subtraction

        /// <summary>
        /// given valid input binary strings, should return valid binary difference
        /// </summary>
        [Test]
        public void BinaryValue_SubtractionInBinaryFromStrings_inputOne_11111111_inputTwo_00000000_should_return_valid_binary()
        {
            // Arrange            
            var inputOne = "11111111";
            var inputTwo = "00000000";
            var expectedBinary = "11111111";

            // Act
            var actualBinary = BinaryValue.SubtractionInBinaryFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedBinary, actualBinary, "converting subtraction to binary: 11111111");
        }

        /// <summary>
        /// given valid input binary strings, should return valid binary difference
        /// checks for handling difference = max int32
        /// </summary>
        [Test]
        public void BinaryValue_SubtractionInBinaryFromStrings_inputOne_10000000000000000000000000000000_inputTwo_1_should_return_valid_binary()
        {
            // Arrange
            var inputOne = "10000000000000000000000000000000";
            var inputTwo = "1";
            var expectedBinary = "1111111111111111111111111111111";

            // Act
            var actualBinary = BinaryValue.SubtractionInBinaryFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedBinary, actualBinary, "converting subtraction to binary: 1111111111111111111111111111111");
        }

        /// <summary>
        /// given valid input binary strings, should return valid decimal difference
        /// </summary>
        [Test]
        public void BinaryValue_SubtractionInDecimalFromStrings_inputOne_11111111_inputTwo_00000000_should_return_valid_decimal()
        {
            // Arrange
            var inputOne = "11111111";
            var inputTwo = "00000000";
            var expectedDecimal = 255;

            // Act
            var actualDecimal = BinaryValue.SubtractionInDecimalFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedDecimal, actualDecimal, "converting subtraction to decimal: 255");
        }

        /// <summary>
        /// given valid input binary strings, should return valid decimal difference
        /// checks for handling difference = max int32
        /// </summary>
        [Test]
        public void BinaryValue_SubtractionInDecimalFromStrings_inputOne_10000000000000000000000000000001_inputTwo_1_should_return_valid_binary()
        {
            // Arrange
            var inputOne = "10000000000000000000000000000001";
            var inputTwo = "1";
            var expectedDecimal = "2147483648";

            // Act
            var actualDecimal = BinaryValue.SubtractionInDecimalFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedDecimal, actualDecimal, "converting subtraction to binary: 2147483648");
        }

        //[Test]
        //public void BinaryValue_SubtractionInBinary_inputOne_11111111_inputTwo_00000000_should_return_valid_binary()
        //{
        //    // Arrange
        //    var inputOne = new BinaryValue("11111111");
        //    var inputTwo = new BinaryValue("00000000");
        //    var expectedBinary = "11111111";

        //    // Act
        //    var actualBinary = BinaryValue.SubtractionInBinary(inputOne, inputTwo);

        //    // Assert
        //    Assert.AreEqual(expectedBinary, actualBinary, "converting subtraction to binary: 11111111");
        //}

        //[Test]
        //public void BinaryValue_SubtractionInBinary_inputOne_10000000000000000000000000000000_inputTwo_1_should_return_valid_binary()
        //{
        //    // Arrange
        //    var inputOne = new BinaryValue("10000000000000000000000000000000");
        //    var inputTwo = new BinaryValue("1");
        //    var expectedBinary = "1111111111111111111111111111111";

        //    // Act
        //    var actualBinary = BinaryValue.SubtractionInBinary(inputOne, inputTwo);

        //    // Assert
        //    Assert.AreEqual(expectedBinary, actualBinary, "converting subtraction to binary: 10000000000000000000000000000000");
        //}

        //[Test]
        //public void BinaryValue_SubtractionInDecimal_inputOne_11111111_inputTwo_00000000_should_return_valid_decimal()
        //{
        //    // Arrange
        //    var inputOne = new BinaryValue("11111111");
        //    var inputTwo = new BinaryValue("00000000");
        //    var expectedDecimal = 255;

        //    // Act
        //    var actualDecimal = BinaryValue.SubtractionInDecimal(inputOne, inputTwo);

        //    // Assert
        //    Assert.AreEqual(expectedDecimal, actualDecimal, "converting subtraction to decimal: 255");
        //}

        //[Test]
        //public void BinaryValue_SubtractionInDecimal_inputOne_10000000000000000000000000000001_inputTwo_1_should_return_valid_decimal()
        //{
        //    // Arrange
        //    var inputOne = new BinaryValue("10000000000000000000000000000001");
        //    var inputTwo = new BinaryValue("1");
        //    var expectedDecimal = 2147483648;

        //    // Act
        //    var actualDecimal = BinaryValue.SubtractionInDecimal(inputOne, inputTwo);

        //    // Assert
        //    Assert.AreEqual(expectedDecimal, actualDecimal, "converting subtraction to decimal: 2147483648");
        //}
        #endregion

        #region Multiply

        /// <summary>
        /// given valid input binary strings, should return valid product binary
        /// </summary>
        [Test]
        public void BinaryValue_MultiplyInBinaryFromStrings_inputOne_11111111_inputTwo_00000000_should_return_valid_binary()
        {
            // Arrange            
            var inputOne = "11111111";
            var inputTwo = "00000000";
            var expectedBinary = "0";

            // Act
            var actualBinary = BinaryValue.MultiplyInBinaryFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedBinary, actualBinary, "converting multiply to binary: 0");
        }

        /// <summary>
        /// given valid input binary strings, should return valid product binary
        /// checks for handling product = max int32
        /// </summary>
        [Test]
        public void BinaryValue_MultiplyInBinaryFromStrings_inputOne_1000000000000000000000000000000_inputTwo_1_should_return_valid_binary()
        {
            // Arrange
            var inputOne = "1000000000000000000000000000000";
            var inputTwo = "10";
            var expectedBinary = "10000000000000000000000000000000";

            // Act
            var actualBinary = BinaryValue.MultiplyInBinaryFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedBinary, actualBinary, "converting multiply to binary: 10000000000000000000000000000000");
        }

        /// <summary>
        /// given valid input binary strings, should return valid decimal product
        /// </summary>
        [Test]
        public void BinaryValue_MultiplyInDecimalFromStrings_inputOne_11111111_inputTwo_00000000_should_return_valid_decimal()
        {
            // Arrange
            var inputOne = "11111111";
            var inputTwo = "00000000";
            var expectedDecimal = 0;

            // Act
            var actualDecimal = BinaryValue.MultiplyInDecimalFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedDecimal, actualDecimal, "converting multiply to decimal: 0");
        }

        /// <summary>
        /// given valid input binary strings, should return valid decimal product
        /// checks for handling product = max int32
        /// </summary>
        [Test]
        public void BinaryValue_MultiplyInDecimalFromStrings_inputOne_1000000000000000000000000000000_inputTwo_10_should_return_valid_binary()
        {
            // Arrange
            var inputOne = "1000000000000000000000000000000";
            var inputTwo = "10";
            var expectedDecimal = "2147483648";

            // Act
            var actualDecimal = BinaryValue.MultiplyInDecimalFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedDecimal, actualDecimal, "converting multiply to binary: 2147483648");
        }
        #endregion

        #region Division

        /// <summary>
        /// given valid input binary strings, should return valid binary quotient
        /// </summary>
        [Test]
        public void BinaryValue_DivisionInBinaryFromStrings_inputOne_10_inputTwo_10_should_return_valid_binary()
        {
            // Arrange            
            var inputOne = "10";
            var inputTwo = "10";
            var expectedBinary = "1";

            // Act
            var actualBinary = BinaryValue.DivisionInBinaryFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedBinary, actualBinary, "converting division to binary: 1");
        }

        /// <summary>
        /// given valid input binary strings, should return valid binary quotient
        /// checks for handling quotient = max int32
        /// </summary>
        [Test]
        public void BinaryValue_DivisionInBinaryFromStrings_inputOne_1000000000000000000000000000000_inputTwo_10_should_return_valid_binary()
        {
            // Arrange
            var inputOne = "10000000000000000000000000000000";
            var inputTwo = "1";
            var expectedBinary = "10000000000000000000000000000000";

            // Act
            var actualBinary = BinaryValue.DivisionInBinaryFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedBinary, actualBinary, "converting multiply to binary: 10000000000000000000000000000000");
        }

        /// <summary>
        /// given valid input binary strings, should return valid decimal quotient
        /// </summary>
        [Test]
        public void BinaryValue_DivisionInDecimalFromStrings_inputOne_10_inputTwo_10_should_return_valid_decimal()
        {
            // Arrange
            var inputOne = "10";
            var inputTwo = "10";
            var expectedDecimal = 1;

            // Act
            var actualDecimal = BinaryValue.DivisionInDecimalFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedDecimal, actualDecimal, "converting division to decimal: 1");
        }

        /// <summary>
        /// given valid input binary strings, should return valid decimal quotient
        /// checks for handling quotient = max int32
        /// </summary>
        [Test]
        public void BinaryValue_DivisionInDecimalFromStrings_inputOne_10000000000000000000000000000000_inputTwo_10_should_return_valid_binary()
        {
            // Arrange
            var inputOne = "10000000000000000000000000000000";
            var inputTwo = "1";
            var expectedDecimal = "2147483648";

            // Act
            var actualDecimal = BinaryValue.DivisionInDecimalFromStrings(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedDecimal, actualDecimal, "converting division to binary: 2147483648");
        }
        #endregion
    }
}
