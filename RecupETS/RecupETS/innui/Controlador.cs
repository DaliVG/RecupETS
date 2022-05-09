using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupETS
{
    class Controlador
    {
        /// <summary>
        /// Intermedia recibiendo los dos numeros entrantes y muestra en interfaz el mensaje de resultado 
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        public static void DataSuma(double numberOne, double numberTwo)
        {
            string error = "";
            double resultSuma = Calculadora.Suma(numberOne, numberTwo, ref error);

            if (error == "")
            {
                Interfaz.ShowSuma(resultSuma);
            }
            else
            {
                Interfaz.ShowError(error);
            }
        }

        public static void DataResta(double numberOne, double numberTwo)
        {
            string error = "";
            double resultResta = Calculadora.Resta(numberOne, numberTwo, ref error);
            
            if (error == "")
            {
                if (resultResta > double.MaxValue)
                {
                    Console.WriteLine("Fuera de rango superior.");
                }
                else
                {
                    if (resultResta < double.MinValue)
                    {
                        Console.WriteLine("Fuera de rango inferior.");
                        Console.WriteLine("Introduzca una tecla para volver al menu");
                        Console.ReadKey(true);
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

        public static void DataMulti(double numberOne, double numberTwo)
        {
            string error = "";
            double resultMulti = Calculadora.Multiplicacion(numberOne, numberTwo, ref error);

            if (error == "")
            {
                Interfaz.ShowMulti(resultMulti);
            }
            else
            {
                Interfaz.ShowError(error);
            }
        }

        public static void DataDiv(double numberOne, double numberTwo)
        {
            string error = "";
            double resultDiv = Calculadora.Division(numberOne, numberTwo, ref error);
            if (error == "")
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
