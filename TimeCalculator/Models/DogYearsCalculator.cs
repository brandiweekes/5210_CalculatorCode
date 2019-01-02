using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class DogYearsCalculator : Calculator
    {
        new public int InputOne { get; set; }

        new public int Result { get; set; }
        
        public int CalculateResut ()
        {
            return InputOne * 7;
        }
        

    }

}