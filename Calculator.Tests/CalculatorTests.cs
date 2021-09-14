using Xunit;
using static Calculator.Calculator;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2, Operation.Plus, 4, false, 6)]
        [InlineData(12, Operation.Plus, 4, false, 16)]
        [InlineData(70, Operation.Plus, 34, false, 104)]

        [InlineData(10, Operation.Minus, 4, false, 6)]
        [InlineData(0, Operation.Minus, 4, false, -4)]
        [InlineData(307, Operation.Minus, 157, false, 150)]

        [InlineData(4, Operation.Multiply, 1, false, 4)]
        [InlineData(7, Operation.Multiply, 0, false, 0)]
        [InlineData(15, Operation.Multiply, 7, false, 105)]

        [InlineData(10, Operation.Divide, 4, false, 2)]
        [InlineData(0, Operation.Divide, 4, false, 0)]
        [InlineData(307, Operation.Divide, 10, false, 30)]
        [InlineData(307, Operation.Divide, 0, true, 0)]

        public void Calculate_Test(int val1, Operation operation, int val2, bool resultExpected1, int resultExpected2)
        {
            Assert.Equal(Calculate(val1, operation, val2, out var result), resultExpected1);
            Assert.Equal(resultExpected2, result);
        }
    }
}