using System;
using Xunit;

namespace BankingTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Given - Arrange
            int a = 10, b = 20, answer;
            // When - Act
            answer = a + b; // can c# add two integers?
            // Then - Assert
            Assert.Equal(30, answer);
           
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(5,5,10)]
        [InlineData(12,2, 14)]
        public void CanAdd(int a, int b, int expected)
        {
            int answer = a + b;

            Assert.Equal(expected, answer);
        }
    }
}
