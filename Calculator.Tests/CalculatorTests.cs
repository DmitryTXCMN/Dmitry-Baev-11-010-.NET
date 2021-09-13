using Xunit;
using static Calculator.Calculator;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2, Operation.Plus, 4, 6)]
        [InlineData(12, Operation.Plus, 4, 16)]
        [InlineData(70, Operation.Plus, 34, 104)]

        [InlineData(10, Operation.Minus, 4, 6)]
        [InlineData(0, Operation.Minus, 4, -4)]
        [InlineData(307, Operation.Minus, 157, 150)]

        [InlineData(4, Operation.Multiply, 1, 4)]
        [InlineData(7, Operation.Multiply, 0, 0)]
        [InlineData(15, Operation.Multiply, 7, 105)]

        [InlineData(10, Operation.Divide, 4, 2)]
        [InlineData(0, Operation.Divide, 4, 0)]
        [InlineData(307, Operation.Divide, 10, 30)]

        public void Calculate_Test(int val1, Operation operation, int val2, int result)
        {
            Assert.Equal(Calculate(val1, operation, val2), result);
        }
    }
}