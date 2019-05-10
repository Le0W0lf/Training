using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ChildClass qqq = new ChildClass();
            qqq.Add(1);
            qqq.Add(2);
            qqq.Add(3);
            qqq.Add(4);
            Assert.Equal(10, qqq.GetPrivateInt());

        }

    }
}
