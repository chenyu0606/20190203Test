using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XunitDLL
{
    public class Class1Tests
    {
        [Fact(DisplayName = "加法测试")]
        public void AddTest()
        {
            var class1 = new Class1();
            //class1.Add(2, 2).ShouldBe(4);
            Assert.Equal(4, class1.Add(2, 2));
        }

        [Fact(DisplayName = "反转测试")]
        public void ReverseTest()
        {
            var class1 = new Class1();
            //class1.Reverse("hello").ShouldBe("olleh");
            Assert.Equal("olleh", class1.Reverse("hello"));
        }
        [Fact(Skip = "跳过测试")]
        public void ReverseWithNull_Test()
        {
            var class1 = new Class1();
            class1.Reverse(null).ShouldBe(null);
        }

        [Theory(DisplayName = "加法测试2")]
        [InlineData(1, 2)]
        public void TheoryPassingTest(int a, int b)
        {
            var class1 = new Class1();
            Assert.Equal(3, class1.Add(a, b));
        }

        [Theory(DisplayName = "加法测试3")]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            var class1 = new Class1();
            Assert.True(class1.IsOdd(value));
        }

    }
}
