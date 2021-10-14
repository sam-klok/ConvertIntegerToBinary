using System;
using Xunit;
using ConvertIntegerToBinary;

namespace XUnitTestProject1
{
    public class ConvertIntegerToBinaryUnitTest
    {
        [Theory]
        [InlineData("0000", 0)]
        [InlineData("11001", 2)]
        [InlineData("0011001011110", 4)]
        public void MaxCountOf1Linq(string s, int expected)
        {
            var i = ConvertIntegerToBinary.Program.MaxCountOf1Linq(s);
            Assert.Equal(expected, i);
        }
        

        [Theory]
        [InlineData("0000", 0)]
        [InlineData("11001", 2)]
        [InlineData("0011001011110", 4)]
        public void MaxCountOf1(string s, int expected)
        {
            var i = ConvertIntegerToBinary.Program.MaxCountOf1(s);
            Assert.Equal(expected, i);
        }
    }
}
