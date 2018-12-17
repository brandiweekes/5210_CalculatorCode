﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorCode.Models
{
    public class BinaryValue
    {
        public String BinaryString { get; set; }
        private int BinaryInt { get; set; }
        public BinaryValue(String inputString)
        {
            BinaryString = inputString;
            BinaryInt = Convert.ToInt32(BinaryString, 2);
        }

        public static int SumInDecimal(BinaryValue inputOne, BinaryValue inputTwo)
        {
            return inputOne.BinaryInt + inputTwo.BinaryInt;
        }

        public static String SumInBinary(BinaryValue inputOne, BinaryValue inputTwo)
        {
            int sum = inputOne.BinaryInt + inputTwo.BinaryInt;
            String result = Convert.ToString(sum, 2);
            return result;

        }

        public static String ConvertToBinary(int input)
        {
            return Convert.ToString(input, 2);
        }
    }
}
