using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
namespace CalcoleterTest
{

   

    [TestClass]
    public class CalcoleterTest
    {

        private Calculator.Calcul calcul;

        [TestMethod]
        public void addition() {

            calcul = new Calculator.Calcul();
   
            string expression = "4 + 4";          
            double result=0;

            Assert.AreEqual(8, calcul.addition(result, expression));
        }

        [TestMethod]
        public void subtraction()
        {

            calcul = new Calculator.Calcul();

            string expression = "4 - 2";
            double result = 0;

            Assert.AreEqual(2, calcul.subtraction(result, expression));
        }
    }
}
