using ConsolApp3;
using System;
using Xunit;


namespace XUnitTestyJednostkowe
{

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Rect rect = new Rect(2, 3);
            int res = rect.Area();
            Assert.Equal(6, res);
        }
    }
}