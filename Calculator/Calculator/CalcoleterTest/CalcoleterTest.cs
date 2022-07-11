﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        public void multiplication()
        {

            calcul = new Calculator.Calcul();

            double num1 = 2;
            double num2 = 2;
            double result = 0;

            Assert.AreEqual(4, calcul.multiplication(num1, num2, result));
        }

        [TestMethod]
        public void division_cas1()
        {

            calcul = new Calculator.Calcul();

            double num1 = 8;
            double num2 = 2;
            double result = 0;

            Assert.AreEqual(4, calcul.division(num1, num2, result));
        }

        [TestMethod]
        public void division_cas2()
        {

            calcul = new Calculator.Calcul();

            double num1 = 0;
            double num2 = 2;
            double result = 0;

            Assert.AreNotEqual(4, calcul.division(num1, num2, result));
        }
    }
}
