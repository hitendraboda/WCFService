using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        /// <summary>
        /// Adds the numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        [OperationContract]
        double AddNumbers(double number1, double number2);

        /// <summary>
        /// Substracts the numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        [OperationContract]
        double SubstractNumbers(double number1, double number2);

        /// <summary>
        /// Multiplies the numbers.
        /// </summary>
        /// <param name="calculatorModel">The calculator model.</param>
        /// <returns></returns>
        [OperationContract]
        double MultiplyNumbers(CalculatorModel calculatorModel);

        /// <summary>
        /// Divisions the numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        [OperationContract]
        double DivisionNumbers(double number1, double number2);

    }

    [DataContract]
    public class CalculatorModel
    {
        /// <summary>
        /// Gets or sets the number1.
        /// </summary>
        /// <value>
        /// The number1.
        /// </value>
        [DataMember]
        public double number1 { get; set; }

        /// <summary>
        /// Gets or sets the number2.
        /// </summary>
        /// <value>
        /// The number2.
        /// </value>
        [DataMember]
        public double number2 { get; set; }
    }
}
