using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProgram
{
    internal class Calculator
    {
        public float result { get; set; }

        public Calculator(int startResult)
        {
            result = startResult;
        }

        public void Add(int number1, int number2)
        {
            result = number1 + number2;
        }

        public void Substract(int number1, int number2)
        {
            result = number1 - number2;
        }

        public void Divide(int number1, int number2)
        {
            result = (float)number1 / (float)number2;
        }

        public void Multiply(int number1, int number2)
        {
            result = number1 * number2;
        }

        public void Add(int number1)
        {
            result += number1;
        }

        public void Substract(int number1)
        {
            result -= number1;
        }

        public void Divide(int number1)
        {
            result /= (float)number1;
        }

        public void Multiply(int number1)
        {
            result *= number1;
        }
    }
}
