using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest.Calculator
{
    public class Add
    {
        public static int Calculate(int operand1, int operand2)
        {
            return operand1 + operand2;
        }
    }

    public class Substract
    {
        public static int Calculate(int operand1, int operand2)
        {
            return operand1 - operand2;
        }
    }

    public class Multiplication
    {
        public static int Calculate(int operand1, int operand2)
        {
            return operand1 * operand2;
        }
    }
    
    public class Division
    {
        public static int Calculate(int operand1, int operand2)
        {
            return operand1 / operand2;
        }
    }
    
    public class Calculator
    {
        public static int Operation(int operand1, int operand2, string operation)
        {
            switch (operation)
            {
                case "add":
                    return Add.Calculate(operand1, operand2);
                case "substract":
                    return Substract.Calculate(operand1, operand2);
                case "multiplication":
                    return Multiplication.Calculate(operand1, operand2);
                case "division":
                    return Division.Calculate(operand1, operand2);
                default:
                    return 0;
            }
        }
    }
}
