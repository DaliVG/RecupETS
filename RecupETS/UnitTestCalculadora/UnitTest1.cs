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
    }
}
