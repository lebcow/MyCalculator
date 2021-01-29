using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCalculator.Classes
{
    public class CalculatorLogic
    {
        public enum OperatorType
        {
            Add,
            Subtract,
            Multiple,
            Divide,
            EqualsTo,
            Clear,
            None
        }
            
        public int Add(int FirstValue,int SecondValue)
        {
            return FirstValue + SecondValue;
        }

        public int Subtract(int FirstValue, int SecondValue)
        {
            return FirstValue - SecondValue;
        }

        public int Multiply(int FirstValue, int SecondValue)
        {
            return FirstValue * SecondValue;
        }

        public int Divide(int FirstValue, int SecondValue)
        {
            return FirstValue / SecondValue;
        }
    }
}
