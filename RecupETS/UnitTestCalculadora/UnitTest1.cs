using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RecupETS;

namespace UnitTestCalculadora
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestMethodSuma1()
        {
            // Arrange 
            decimal numberOne = 4;
            decimal numberTwo = 4;

            // Act
            decimal resultSuma = Calculadora.Suma(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(resultSuma, 8);
        }

        /* public void TestMethodMaxValue1()
         {
             // Arrange 
             decimal numberOne = decimal.MaxValue;
             decimal numberTwo = 1;

             // Act
             decimal resultSuma = Calculadora.Suma(numberOne, numberTwo);

             // Assert
             Assert.AreEqual(error);
         }*/
        [TestMethod]
        public void TestMethodResta1()
        {
            // Arrange 
            decimal numberOne = -254;
            decimal numberTwo = 10;

            // Act
            decimal resultResta = Calculadora.Resta(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(resultResta, -264);
        }
        [TestMethod]
        public void TestMethodMultiplicacion1()
        {
            // Arrange 
            decimal numberOne = 2.37M;
            decimal numberTwo = 47;

            // Act
            decimal resultMulti = Calculadora.Multiplicacion(numberOne, numberTwo);
            decimal resultadoCorrecto = 111.39M;
            // Assert
            Assert.AreEqual(resultMulti, resultadoCorrecto*(-1));
        }

        [TestMethod]
        public void TestMethodDiv1()
        {
            // Arrange 
            decimal numberOne = 47.2M;
            decimal numberTwo = 3.25M;

            // Act
            decimal resultDiv = Calculadora.Division(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(resultDiv, 12.98461538461538M);
        }
    }
}
