using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupETS
{
    class Controlador
    {
        public static void DataSuma(decimal numberOne, decimal numberTwo)
        {
            decimal resultSuma = Calculadora.Suma(numberOne, numberTwo);
            Interfaz.ShowSuma(resultSuma);

        }

        public static void DataResta(decimal numberOne, decimal numberTwo)
        {
            decimal resultResta = Calculadora.Resta(numberOne, numberTwo);
            Interfaz.ShowResta(resultResta);

        }

        public static void DataMulti(decimal numberOne, decimal numberTwo)
        {
            decimal resultMulti = Calculadora.Multiplicacion(numberOne, numberTwo);
            Interfaz.ShowMulti(resultMulti);

        }

        public static void DataDiv(decimal numberOne, decimal numberTwo)
        {
            decimal resultDiv = Calculadora.Division(numberOne, numberTwo);
            Interfaz.ShowDiv(resultDiv);

        }


    }
}
