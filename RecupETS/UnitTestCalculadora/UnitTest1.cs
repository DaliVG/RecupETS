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
            double numberOne = 4;
            double numberTwo = 4;

            // Act
            string error = "";
            double resultSuma = Calculadora.Suma(numberOne, numberTwo, ref error);

            // Assert
            Assert.AreEqual(resultSuma, 8);
        }

        [TestMethod]
        public void TestMethodMaxValue1()
        {
            // Arrange 
            double numberOne = 1.7976931348623157E+308;
            double numberTwo = 25;

            // Act
            string error = "";
            double resultSuma = Calculadora.Suma(numberOne, numberTwo, ref error);
            string noError = "";

            // Assert
            Assert.AreNotEqual(noError, error);
        }

        [TestMethod]
        public void TestMethodResta1()
        {
            // Arrange 
            double numberOne = -254;
            double numberTwo = 10;

            // Act
            string error = "";
            double resultResta = Calculadora.Resta(numberOne, numberTwo, ref error);

            // Assert
            Assert.AreEqual(resultResta, -264);
        }


        [TestMethod]
        public void TestMethodMultiplicacion1()
        {
            // Arrange 
            double numberOne = 123.45;
            double numberTwo = 135;

            // Act
            string error = "";
            double resultMulti = Calculadora.Multiplicacion(numberOne, numberTwo, ref error);
            double resultadoCorrecto = 16665.75;
            // Assert
            Assert.AreEqual(resultMulti, resultadoCorrecto);
        }

        [TestMethod]
        public void TestMethodInfinito1()
        {
            // Arrange 
            double numberOne = double.PositiveInfinity;
            double numberTwo = 135;

            // Act
            string error = "";
            double resultMulti = Calculadora.Multiplicacion(numberOne, numberTwo, ref error);
            // Assert
            Assert.AreEqual(double.PositiveInfinity, resultMulti);
        }

        [TestMethod]
        public void TestMethodDiv1()
        {
            // Arrange 
            double numberOne = 3.1;
            double numberTwo = 2.1;

            // Act
            string error = "";
            double resultDiv = Calculadora.Division(numberOne, numberTwo, ref error);
            double resultadoCorrecto = 1.476190476190476;
            // Assert
            Assert.AreEqual(Convert.ToDecimal(resultDiv), Convert.ToDecimal(resultadoCorrecto));
        }
    }
}
