using Xunit;
using static Calculator.Parser;
using static Calculator.Calculator;

namespace Calculator.Tests
{
    public class ParserTests
    {
        [Theory]
        [InlineData("+", false)]
        [InlineData("-", false)]
        [InlineData("*", false)]
        [InlineData("/", false)]
        [InlineData("1", true)]
        [InlineData("41", true)]
        [InlineData("++", true)]
        public void TryParsOperatorOrQuit_Test(string arg, bool result)
        {
            Assert.Equal(TryParsOperatorOrQuit(arg,out Operation operation), result);
        }

        [Theory]
        [InlineData("41", false)]
        [InlineData("1", false)]
        [InlineData("7", false)]
        [InlineData("494", false)]
        [InlineData("-", true)]
        [InlineData("44rfqwe", true)]
        [InlineData("++", true)]
        public void TryParsArgOrQuit_Test(string arg, bool result)
        {
            Assert.Equal(TryParsArgsOrQuit(arg, out int methodResult), result);
        }

        [Theory]
        [InlineData(new[] { "1", "2", "3" }, false)]
        [InlineData(new[] { "`", "q", "a" }, false)]
        [InlineData(new[] { "1daw", "7ryhe", "`3`1d" }, false)]
        [InlineData(new[] { "1", "2" }, true)]
        [InlineData(new[] { "1", "2", "3", "fqw12" }, true)]
        [InlineData(new[] { "" }, true)]
        public void CheckArgsLenghtOrQuit_Test(string[] args, bool result)
        {
            Assert.Equal(CheckArgsLenghtOrQuit(args), result);
        }

        
    }
}