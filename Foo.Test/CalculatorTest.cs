using Xunit;

namespace Foo.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            Assert.Equal(3, Calculator.Add(1, 2));
        }
    }
}
