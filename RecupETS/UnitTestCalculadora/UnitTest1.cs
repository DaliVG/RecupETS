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
            string error = "";
            decimal resultSuma = Calculadora.Suma(numberOne, numberTwo, ref error);

            // Assert
            Assert.AreEqual(resultSuma, 8);
        }

        [TestMethod]
        public void TestMethodMaxValue1()
        {
            // Arrange 
            decimal numberOne = 79228162514264337593543950335m;
            decimal numberTwo = 1;

            // Act
            string error = "";
            decimal resultSuma = Calculadora.Suma(numberOne, numberTwo, ref error);
            string noError = "";

            // Assert
            Assert.AreNotEqual(noError, error);
        }

        [TestMethod]
        public void TestMethodResta1()
        {
            // Arrange 
            decimal numberOne = -254;
            decimal numberTwo = 10;

            // Act
            string error = "";
            decimal resultResta = Calculadora.Resta(numberOne, numberTwo, ref error);

            // Assert
            Assert.AreEqual(resultResta, -264);
        }


        [TestMethod]
        public void TestMethodMultiplicacion1()
        {
            // Arrange 
            decimal numberOne = 123.45M;
            decimal numberTwo = -135;

            // Act
            string error = "";
            decimal resultMulti = Calculadora.Multiplicacion(numberOne, numberTwo, ref error);
            decimal resultadoCorrecto = -16665.75M;
            // Assert
            Assert.AreEqual(resultMulti, resultadoCorrecto);
        }

        [TestMethod]
        public void TestMethodInfinito1()
        {
            // Arrange 
            decimal numberOne = +00M;
            decimal numberTwo = -135;

            // Act
            string error = "";
            decimal resultMulti = Calculadora.Multiplicacion(numberOne, numberTwo, ref error);
            // Assert
            Assert.AreEqual(double.NaN, Convert.ToDouble(resultMulti));
        }

        [TestMethod]
        public void TestMethodDiv1()
        {
            // Arrange 
            decimal numberOne = 48.2M;
            decimal numberTwo = 2.25M;

            // Act
            string error = "";
            decimal resultDiv = Calculadora.Division(numberOne, numberTwo, ref error);
            decimal resultadoCorrecto = 21.422222222222222222222222222M;
            // Assert
            Assert.AreEqual(resultDiv, resultadoCorrecto);
        }
    }
}
