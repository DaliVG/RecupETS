using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupETS
{
    public class Calculadora
    {
        public static readonly decimal MinValue;
        public static readonly decimal MaxValue;
        public const decimal NegativeInfinity = -00;
        public const decimal PositiveInfinity = +00;

        public static decimal Suma(decimal numberOne, decimal numberTwo)
        {
            decimal resultSuma = 0;
            resultSuma = numberOne + numberTwo;

            Interfaz.ShowSuma(resultSuma);
            Console.ReadKey();
            return resultSuma;
        }

        public static decimal Resta(decimal numberOne, decimal numberTwo)
        {
            decimal resultResta = 0;
            resultResta = numberOne - numberTwo;
            Interfaz.ShowResta(resultResta);
            Console.ReadKey();
            return resultResta;
        }

        public static decimal Multiplicacion(decimal numberOne, decimal numberTwo)
        {
            decimal resultMulti = 0;
            resultMulti = numberOne * numberTwo;

            Interfaz.ShowMulti(resultMulti);
            Console.ReadKey();
            return resultMulti;
        }


        public static decimal Division(decimal numberOne, decimal numberTwo)
        {
            decimal resultDiv = 0;

            if (numberTwo != 0)
            {
                resultDiv = numberOne + numberTwo;

                Interfaz.ShowDiv(resultDiv);
                Console.ReadKey();
            }
            else
            {
                resultDiv = 0;
                Console.WriteLine("No se puede dividir entre 0.");
            }

            return resultDiv;
        }
    }
}
