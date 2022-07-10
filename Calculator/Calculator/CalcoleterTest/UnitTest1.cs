using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
namespace CalcoleterTest
{

   

    [TestClass]
    public class UnitTest1
    {

        private Calculator.Calcul calcul;

        [TestMethod]
        public void TestMethod1() {


            calcul = new Calculator.Calcul();

            double num1 = 2;
            double num2 = 2;
            double result = 0;


            Assert.AreEqual(4, calcul.addition(num1, num2,result));
        }
    }
}
