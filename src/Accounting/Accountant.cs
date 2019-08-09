using Math;
using System;

namespace Accounting
{
    public class Accountant
    {
        public Calculator Calculator { get; set; }

        public int Sum(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("At least two values are needed to this operation");
            }

            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result = Calculator.Sum(result, numbers[i]);
            }

            return result;
        }

        public int Subtract(int v1, int v2)
        {
            return Calculator.Subtract(v1, v2);
        }

        public int Multiply(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("At least two values are needed to this operation");
            }

            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result = Calculator.Multiply(result, numbers[i]);
            }

            return result;
        }

        public decimal Divide(int v1, int v2)
        {
            try
            {
                return Calculator.Divide(v1, v2);
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
    }
}
