using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupETS
{
    class Interfaz
    {
        public static void Menu()
        {
            char opcion = ' ';

            do
            {
                Console.Clear();
                double numberOne = Functions.AskNumbers();
                double numberTwo = Functions.AskNumbers();
                ShowMenu(numberOne, numberTwo);
                opcion = Lectura();
                switch (opcion)
                {
                    case '1': Controlador.DataSuma(numberOne, numberTwo); break;
                    case '2': Controlador.DataResta(numberOne, numberTwo); break;
                    case '3': Controlador.DataMulti(numberOne, numberTwo); break;
                    case '4': Controlador.DataDiv(numberOne, numberTwo); break;
                    case '5': Functions.Adios(); break;
                }
            }
            while (opcion != '5');
        }

        public static char Lectura()
        {
            ConsoleKeyInfo key;
            char value;
            do
            {
                value = '0';
                key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case '+': value = '1'; break;
                    case '-': value = '2'; break;
                    case '*': value = '3'; break;
                    case '/': value = '4'; break;
                    case 'x': value = '5'; break;
                }
            }
            while (value == '0');

            return value;
        }

        private static void ShowMenu(double numberOne, double numberTwo)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("---------------------- CALCULADORA -------------------");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-    Número 1: " + numberOne + "    Número 2:" + numberTwo + "         ");
            Console.WriteLine("-   Introduzca qué tipo de operación desea realizar  -");
            Console.WriteLine("-                                                    -");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-                                                    -");
            Console.WriteLine("-                   + para sumar                     -");
            Console.WriteLine("-                   - para restar                    -");
            Console.WriteLine("-                * para multiplicar                  -");
            Console.WriteLine("-                  / para dividir                    -");
            Console.WriteLine("-                   x para salir                     -");
            Console.WriteLine("-                                                    -");
            Console.WriteLine("------------------------------------------------------");
        }

        public static void ShowSuma(double ResultSuma)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-                                                    -");
            Console.WriteLine("- Resultado suma:" + ResultSuma);
            Console.WriteLine("-                                                    -");
            Console.WriteLine("------------------------------------------------------");

        }
        public static void ShowResta(double ResultResta)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-                                                    -");
            Console.WriteLine("- Resultado resta:" + ResultResta);
            Console.WriteLine("-                                                    -");
            Console.WriteLine("------------------------------------------------------");

        }
        public static void ShowMulti(double ResultMulti)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-                                                    -");
            Console.WriteLine("- Resultado multiplicación:" + ResultMulti);
            Console.WriteLine("-                                                    -");
            Console.WriteLine("------------------------------------------------------");
            Console.ReadKey();
        }
        public static void ShowDiv(double ResultDiv)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-                                                    -");
            Console.WriteLine("- Resultado división:" + ResultDiv);
            Console.WriteLine("-                                                    -");
            Console.WriteLine("------------------------------------------------------");

        }

        public static void ShowError(string error)
        {
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine("-      Error      -");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("   "+error);

        }
    }
}
