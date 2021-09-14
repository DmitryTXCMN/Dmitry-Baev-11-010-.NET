using Xunit;
using static Calculator.Program;

namespace Calculator.Tests
{
    public class MainTests
    {
        [Theory]
        [InlineData(new[] { "1", "+", "3" }, 0)]
        [InlineData(new[] { "9", "-", "3" }, 0)]
        [InlineData(new[] { "2", "*", "6" }, 0)]
        [InlineData(new[] { "14", "/"}, 1)]
        [InlineData(new[] { "412qawf" }, 1)]
        [InlineData(new[] { "2", "*", "6", "q" }, 1)]
        [InlineData(new[] { "14", "13", "" }, 2)]
        [InlineData(new[] { "ff", "/", "qq1" }, 2)]
        [InlineData(new[] { "q", "+", "4" }, 2)]
        [InlineData(new[] { "1", "q", "3" }, 3)]
        [InlineData(new[] { "9", "", "3" }, 3)]
        [InlineData(new[] { "2", "52", "6" }, 3)]
        [InlineData(new[] { "2", "/", "0" }, 4)]
        public void TryParsOperatorOrQuit_Test(string[] args, int result)
        {
            Assert.Equal(Main(args), result);
        }
    }
}
