using Xunit;
using DotNot;

namespace XUnitTests
{
    public class DotNotTest
    {
        [Theory]
        [InlineData(false, true)]
        [InlineData(true, false)]
        public void DotNot(bool value, bool expected)
        {
            bool actual = value.Not();
            Assert.Equal(expected, actual);
        }
    }
}
