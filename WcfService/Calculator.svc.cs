﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculator.svc or Calculator.svc.cs at the Solution Explorer and start debugging.
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Adds the numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns>Adds result</returns>
        public double AddNumbers(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }

        /// <summary>
        /// Substracts the numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns>Substracts result</returns>
        public double SubstractNumbers(double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }

        /// <summary>
        /// Multiplies the numbers.
        /// </summary>
        /// <param name="calculatorModel">The calculator model.</param>
        /// <returns>Multiplies result</returns>
        public double MultiplyNumbers(CalculatorModel calculatorModel)
        {
            double result = calculatorModel.number1 * calculatorModel.number2;
            return result;
        }

        /// <summary>
        /// Divisions the numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns>Divisions result</returns>
        public double DivisionNumbers(double number1, double number2)
        {
            double result = number1 / number2;
            return result;
        }
    }
}
