using Xunit;

namespace AIC.Functionality.Tests
{
    public class AlgorithmTests
    {
        [Fact(Skip = "Not implemented")]
        public void CanFormatSeparators()
        {
            var list = new List<string> { "red", "green", "purple", "yellow", "pink" };

            Assert.Equal("red, green, purple, yellow, and pink!", Algorithms.BuildFormattedString(list));
        }


        [Fact(Skip = "Not implemented")]
        public void CanGetFactorial()
        {
            Assert.Equal(24, Algorithms.GetFactorial(4));
        }
    }
}
