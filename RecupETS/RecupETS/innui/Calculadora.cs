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

        public static decimal Suma(decimal numberOne, decimal numberTwo, ref string error)
        {
            decimal resultSuma = 0;
            try
            {
                resultSuma = numberOne + numberTwo;
            }
            catch (Exception)
            {
                error = ("resultado fuera de rango de memoria");
            }

            return resultSuma;
        }

        public static decimal Resta(decimal numberOne, decimal numberTwo, ref string error)
        {
            decimal resultResta = 0;
            try
            {
                resultResta = numberOne - numberTwo;

            }
            catch (Exception)
            {
                if (resultResta > decimal.MaxValue)
                {
                    error = ("Fuera de rango superior.");
                }
                else
                {
                    if (resultResta < decimal.MinValue)
                    {
                        error = ("Fuera de rango inferior.");
                    }

                }
            }
            return resultResta;
        }

        public static decimal Multiplicacion(decimal numberOne, decimal numberTwo, ref string error)
        {
            decimal resultMulti = 0;
            try
            {
                resultMulti = numberOne * numberTwo;

            }
            catch (Exception)
            {
                if (resultMulti > decimal.MaxValue)
                {
                    error = ("Fuera de rango superior.");
                }
                else
                {
                    if (resultMulti < decimal.MinValue)
                    {
                        error = ("Fuera de rango inferior.");
                    }

                }


            }

            return resultMulti;
        }
        public static decimal Division(decimal numberOne, decimal numberTwo, ref string error)
        {
            decimal resultDiv = 0;

            if (numberTwo != 0)
            {
                try
                {
                    resultDiv = numberOne / numberTwo;

                }
                catch (Exception)
                {
                    if (resultDiv > decimal.MaxValue)
                    {
                        error = ("Fuera de rango superior.");
                    }
                    else
                    {
                        if (resultDiv < decimal.MinValue)
                        {
                            error = ("Fuera de rango inferior.");
                        }

                    }
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


