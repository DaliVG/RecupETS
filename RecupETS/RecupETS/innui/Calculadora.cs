using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupETS
{
    public class Calculadora
    {
        public static readonly double MinValue;
        public static readonly double MaxValue;
        public const double NegativeInfinity = -00;
        public const double PositiveInfinity = +00;
        /// <summary>
        /// Procede a sumar y comprueba error de fuera de rango
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <param name="error"></param>
        /// <returns>resultSuma</returns>
        public static double Suma(double numberOne, double numberTwo, ref string error)
        {
            double resultSuma = 0;
            resultSuma = numberOne + numberTwo;

            if (resultSuma > MaxValue || resultSuma < MinValue)
            {
                error = ("resultado fuera de rango de memoria");
            }

            return resultSuma;
        }

        /// <summary>
        /// Procede a restar y comprueba error de fuera de rango
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <param name="error"></param>
        /// <returns>resultResta</returns>
        public static double Resta(double numberOne, double numberTwo, ref string error)
        {
            double resultResta = 0;
            try
            {
                resultResta = numberOne - numberTwo;

            }
            catch (Exception)
            {
                error = ("resultado fuera de rango de memoria");
            }
            return resultResta;
        }
        /// <summary>
        /// Procede a Multiplicar y comprueba error de fuera de rango
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <param name="error"></param>
        /// <returns>resultMulti</returns>
        public static double Multiplicacion(double numberOne, double numberTwo, ref string error)
        {
            double resultMulti = 0;
            try
            {
                resultMulti = numberOne * numberTwo;

            }
            catch (Exception)
            {
                error = ("resultado fuera de rango de memoria");

            }

            return resultMulti;
        }
        /// <summary>
        /// Procede a dividir y comprueba error de fuera de rango, además de comprobar la division entre cero.
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static double Division(double numberOne, double numberTwo, ref string error)
        {
            double resultDiv = 0;

            if (numberTwo != 0)
            {
                try
                {
                    resultDiv = numberOne / numberTwo;

                }
                catch (Exception)
                {
                    error = ("resultado fuera de rango de memoria");
                }
            }
            else
            {
                resultDiv = 0;
                error = ("No se puede dividir entre 0.");
            }

            return resultDiv;
        }
    }
}


