using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumeSevice.CalculatorService;

namespace ConsumeSevice
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient proxy = new CalculatorClient();

            Console.WriteLine("Enter Number1");
            double number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number2");
            double number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\n");
            Console.Write("Result\n");
            Console.Write("===================================\n");

            double addResult = proxy.AddNumbers(number1, number2);
            Console.WriteLine("Add Operation : {0}\n",addResult);

            double subResult = proxy.SubstractNumbers(number1, number2);
            Console.WriteLine("Substract Operation : {0}\n",subResult);

            double mulResult = proxy.MultiplyNumbers(new CalculatorModel() { number1 = number1, number2 = number2 });
            Console.WriteLine("Multiply Operation : {0}\n",mulResult);

            double divResult = proxy.DivisionNumbers(number1, number2);
            Console.WriteLine("Division Operation : {0}\n",divResult);

            Console.Write("===================================\n");
            Console.Write("Please Enter to Exit...");

            Console.ReadKey(true);

            proxy.Close();

        }
    }
}
