using Xunit;
using Calculator;

namespace CalculeterTest
{
    public class CalculeterTest
    {
        private Calculator.Calcul calculator;


        [Fact]
        public void Add()
        {
            Assert.Equals(4, calculator.addition(2, 2, 4));

        }
    }
}