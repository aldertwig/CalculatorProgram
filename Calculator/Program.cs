using System;
using System.ComponentModel;

namespace CalculatorProgram
{
    internal class Program
    {
        enum Operator
        {
            Addition = '+',
            Substraction = '-',
            Division = '/',
            Multiplication = '*'
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator(startResult: 0);

            bool runCalculator = true;
            Console.WriteLine($"Operators: {(char)Operator.Addition} " +
                              $"{(char)Operator.Substraction} " +
                              $"{(char)Operator.Division} " +
                              $"{(char)Operator.Multiplication} " +
                              "Usage: NUMBER OPERATOR NUMBER (ENTER)");
            while (runCalculator)
            {

                string inputString = Console.ReadLine();
                if (inputString.Length > 0)
                {
                    char calcOperator = ' ';
                    int number1 = 0;
                    int number2 = 0;
                    string[] inputSplitted = inputString.Split(' ');

                    if (inputSplitted.Length == 3)
                    {
                        calcOperator = Convert.ToChar(inputSplitted[1]);
                        number1 = Convert.ToInt32(inputSplitted[0]);
                        number2 = Convert.ToInt32(inputSplitted[2]);
                    }
                    else if (inputSplitted.Length == 2)
                    {
                        calcOperator = Convert.ToChar(inputSplitted[0]);
                        number1 = Convert.ToInt32(inputSplitted[1]);
                    }

                    switch (calcOperator)
                    {
                        case (char)Operator.Addition:
                            if (inputSplitted.Length == 3)
                            {
                                calc.Add(number1, number2);
                            }
                            else if (inputSplitted.Length == 2)
                            {
                                calc.Add(number1);
                            }
                            Console.WriteLine(calc.result);
                            break;
                        case (char)Operator.Substraction:
                            if (inputSplitted.Length == 3)
                            {
                                calc.Substract(number1, number2);
                            }
                            else if (inputSplitted.Length == 2)
                            {
                                calc.Substract(number1);
                            }
                            Console.WriteLine(calc.result);
                            break;
                        case (char)Operator.Division:
                            if (inputSplitted.Length == 3)
                            {
                                calc.Divide(number1, number2);
                            }
                            else if (inputSplitted.Length == 2)
                            {
                                calc.Divide(number1);
                            }
                            Console.WriteLine(calc.result);
                            break;
                        case (char)Operator.Multiplication:
                            if (inputSplitted.Length == 3)
                            {
                                calc.Multiply(number1, number2);
                            }
                            else if (inputSplitted.Length == 2)
                            {
                                calc.Multiply(number1);
                            }
                            Console.WriteLine(calc.result);
                            break;
                        default:
                            Console.Write($"Use operators: {(char)Operator.Addition} " +
                                            $"{(char)Operator.Substraction} " +
                                            $"{(char)Operator.Division} " +
                                            $"{(char)Operator.Multiplication}");
                            Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    runCalculator = false;
                }
            }
        }
    }
}