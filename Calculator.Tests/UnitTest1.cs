using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.Add(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }
        [Theory]
        [InlineData(3, 34)]
        [InlineData(5, 4)]
        [InlineData(6, 7)]

        public void SubtractTwoIntegers(int a, int b)
        {
            // Given this input to the method
            int dif = _calculator.Subtract(a, b);

            // We are asserting that the output should be this
            Assert.Equal(dif, a - b);
        }

        [Fact]        
        public void MultiplyTwoIntegers()
        {
            // Given this input to the method
            int mult = _calculator.Multiply(4, 9);

            // We are asserting that the output should be this
            Assert.Equal(mult, 36);
        }

        [Fact]        
        public void DivideTwoIntegers()
        {
            // Given this input to the method
            int div = _calculator.Divide(54, 6);

            // We are asserting that the output should be this
            Assert.Equal(div, 9);
        }
    }
}