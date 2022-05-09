using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupETS
{
    class Calculadora
    {
        public static void Suma(decimal numberOne, decimal numberTwo)
        {
            decimal resultSuma = 0;
            resultSuma = numberOne + numberTwo;

            Interfaz.ShowSuma(resultSuma);
        }

        public static void Resta(decimal numberOne, decimal numberTwo)
        {
            decimal resultResta = 0;
            resultResta = numberOne - numberTwo;
            Interfaz.ShowResta(resultResta);
        }

        public static void Multiplicacion(decimal numberOne, decimal numberTwo)
        {
            decimal resultMulti = 0;
            resultMulti = numberOne * numberTwo;

            Interfaz.ShowMulti(resultMulti);
        }

        public static void Division(decimal numberOne, decimal numberTwo)
        {
            decimal resultDiv = 0;

            if (numberTwo != 0)
            {
                resultDiv = numberOne + numberTwo;
                Interfaz.ShowDiv(resultDiv);
            }
            else
            {
                resultDiv = 0;
                Console.WriteLine("No se puede dividir entre 0.");
            }
        }
    }
}
