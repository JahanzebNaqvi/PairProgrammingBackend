using System;
using Xunit;

namespace TestsXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true,"Initial Testing");
        }
    }
}