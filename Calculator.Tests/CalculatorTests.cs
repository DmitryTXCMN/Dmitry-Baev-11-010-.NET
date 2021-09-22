using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2, CalculatorWithIL.Calculator.Operation.Plus, 4)]
        [InlineData(12, CalculatorWithIL.Calculator.Operation.Plus, 4)]
        [InlineData(70, CalculatorWithIL.Calculator.Operation.Plus, 34)]
        public void Calculate_WithPlusOperation_SumReturned(int val1, CalculatorWithIL.Calculator.Operation operation, int val2)
        {
            var resultExpected = val1 + val2;
            CalculatorWithIL.Calculator.Calculate(val1, operation, val2, out var result);
            Assert.Equal(resultExpected, result);
        }

        [Theory]
        [InlineData(10, CalculatorWithIL.Calculator.Operation.Minus, 4)]
        [InlineData(0, CalculatorWithIL.Calculator.Operation.Minus, 4)]
        [InlineData(307, CalculatorWithIL.Calculator.Operation.Minus, 157)]
        public void Calculate_WithMinusOperation_DifferenceReturned(int val1, CalculatorWithIL.Calculator.Operation operation, int val2)
        {
            var resultExpected = val1 - val2;
            CalculatorWithIL.Calculator.Calculate(val1, operation, val2, out var result);
            Assert.Equal(resultExpected, result);
        }

        [Theory]
        [InlineData(4, CalculatorWithIL.Calculator.Operation.Multiply, 1)]
        [InlineData(7, CalculatorWithIL.Calculator.Operation.Multiply, 0)]
        [InlineData(15, CalculatorWithIL.Calculator.Operation.Multiply, 7)]
        public void Calculate_WithMultiplyOperation_ManyReturned(int val1, CalculatorWithIL.Calculator.Operation operation, int val2)
        {
            var resultExpected = val1 * val2;
            CalculatorWithIL.Calculator.Calculate(val1, operation, val2, out var result);
            Assert.Equal(resultExpected, result);
        }

        [Theory]
        [InlineData(10, CalculatorWithIL.Calculator.Operation.Divide, 4)]
        [InlineData(0, CalculatorWithIL.Calculator.Operation.Divide, 4)]
        [InlineData(307, CalculatorWithIL.Calculator.Operation.Divide, 10)]
        public void Calculate_WithDevideOperation_QuotientReturned(int val1, CalculatorWithIL.Calculator.Operation operation, int val2)
        {
            var resultExpected = val1 / val2;
            CalculatorWithIL.Calculator.Calculate(val1, operation, val2, out var result);
            Assert.Equal(resultExpected, result);
        }

        [Theory]
        [InlineData(307, CalculatorWithIL.Calculator.Operation.Divide, 0)]
        public void Calculate_DivisionByZero_trueReturned(int val1, CalculatorWithIL.Calculator.Operation operation, int val2)
        {
            Assert.True(CalculatorWithIL.Calculator.Calculate(val1, operation, val2, out var result));
        }
    }
}