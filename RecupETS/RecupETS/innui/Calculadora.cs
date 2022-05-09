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

        public static double Suma(double numberOne, double numberTwo, ref string error)
        {
            double resultSuma = 0;
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

        public static double Resta(double numberOne, double numberTwo, ref string error)
        {
            double resultResta = 0;
            try
            {
                resultResta = numberOne - numberTwo;

            }
            catch (Exception)
            {
                if (resultResta > double.MaxValue)
                {
                    error = ("Fuera de rango superior.");
                }
                else
                {
                    if (resultResta < double.MinValue)
                    {
                        error = ("Fuera de rango inferior.");
                    }

                }
            }
            return resultResta;
        }

        public static double Multiplicacion(double numberOne, double numberTwo, ref string error)
        {
            double resultMulti = 0;
            try
            {
                resultMulti = numberOne * numberTwo;

            }
            catch (Exception)
            {
                if (resultMulti > double.MaxValue)
                {
                    error = ("Fuera de rango superior.");
                }
                else
                {
                    if (resultMulti < double.MinValue)
                    {
                        error = ("Fuera de rango inferior.");
                    }

                }


            }

            return resultMulti;
        }
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
                    if (resultDiv > double.MaxValue)
                    {
                        error = ("Fuera de rango superior.");
                    }
                    else
                    {
                        if (resultDiv < double.MinValue)
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


