using System;
using Xunit;

namespace WpfAppCore.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = 5;
            Assert.True(x == 5);
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(2,2);
        }
    }
}
