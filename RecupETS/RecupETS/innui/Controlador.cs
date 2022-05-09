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
            string error = "";
            decimal resultSuma = Calculadora.Suma(numberOne, numberTwo, ref error);

            if (error != "")
            {
                Interfaz.ShowSuma(resultSuma);
            }
            else
            {
                Interfaz.ShowError(error);
            }
        }

        public static void DataResta(decimal numberOne, decimal numberTwo)
        {
            string error = "";
            decimal resultResta = Calculadora.Resta(numberOne, numberTwo, ref error);
            
            if (error != "")
            {
                if (resultResta > decimal.MaxValue)
                {
                    Console.WriteLine("Fuera de rango superior.");
                }
                else
                {
                    if (resultResta < decimal.MinValue)
                    {
                        Console.WriteLine("Fuera de rango inferior.");
                    }
                    else
                    {
                        Interfaz.ShowResta(resultResta);
                    }

                }

            }
            else
            {
                Interfaz.ShowError(error);
            }
        }

        public static void DataMulti(decimal numberOne, decimal numberTwo)
        {
            string error = "";
            decimal resultMulti = Calculadora.Multiplicacion(numberOne, numberTwo, ref error);

            if (error != "")
            {
                Interfaz.ShowMulti(resultMulti);
            }
            else
            {
                Interfaz.ShowError(error);
            }
        }

        public static void DataDiv(decimal numberOne, decimal numberTwo)
        {
            string error = "";
            decimal resultDiv = Calculadora.Division(numberOne, numberTwo, ref error);
            if (error != "")
            {
                Interfaz.ShowDiv(resultDiv);
            }
            else
            {
                Interfaz.ShowError(error);
            }

        }


    }
}
