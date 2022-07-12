using Xunit;
using Calculator;

namespace CalculTest
{


    public class Calculater
    {

        private Calculator.Calcul calcul;

        [Fact]
        public void addition_cas1()
        {
            calcul = new Calculator.Calcul();

            double num1 = 2;
            double num2 = 2;
            double result = 0;

            Assert.Equal(4, calcul.addition(num1, num2, result));

        }


        [Fact]
        public void addition_cas2()
        {
            calcul = new Calculator.Calcul();

            double[] num1 = {2,2,2,2};
            double result = 0;

            Assert.Equal(8, calcul.addition(num1, result));

        }


        [Fact]
        public void subtraction_cas1()
        {

            calcul = new Calculator.Calcul();

            double num1 = 4;
            double num2 = 2;
            double result = 0;

            Assert.Equal(2, calcul.subtraction(num1, num2, result));
        }

        [Fact]
        public void subtraction_cas2()
        {

            calcul = new Calculator.Calcul();

            double [] num1 = {15,5,2,2};
            double result = 0;

            Assert.Equal(6, calcul.subtraction(num1, result));
        }


        [Fact]
        public void multiplication()
        {

            calcul = new Calculator.Calcul();

            double num1 = 2;
            double num2 = 2;
            double result = 0;

            Assert.Equal(4, calcul.multiplication(num1, num2, result));
        }
        [Fact]
        public void division_cas1()
        {

            calcul = new Calculator.Calcul();

            double num1 = 8;
            double num2 = 2;
            double result = 0;

            Assert.Equal(4, calcul.division(num1, num2, result));
        }
        [Fact]
        public void division_cas2()
        {

            calcul = new Calculator.Calcul();

            double num1 = 0;
            double num2 = 2;
            double result = 0;

            Assert.NotEqual(4, calcul.division(num1, num2, result));
        }

    }
}