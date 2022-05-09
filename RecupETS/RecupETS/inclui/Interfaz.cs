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
                decimal numberOne = Functions.AskNumbers();
                decimal numberTwo = Functions.AskNumbers();
                ShowMenu(numberOne, numberTwo);
                opcion = Lectura();
                switch (opcion)
                {
                    case '1': Calculadora.Suma(numberOne, numberTwo); break;
                    case '2': Calculadora.Resta(numberOne, numberTwo); break;
                    case '3': Calculadora.Multiplicacion(numberOne, numberTwo); break;
                    case '4': Calculadora.Division(numberOne, numberTwo); break;
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

        private static void ShowMenu(decimal numberOne, decimal numberTwo)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("---------------------- CALCULADORA -------------------");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-    Número 1: "+numberOne+"    Número 2:"+numberTwo+"         ");
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

        public static void ShowSuma(decimal ResultSuma)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-                                                    -");
            Console.WriteLine("- Resultado suma:" + ResultSuma);
            Console.WriteLine("-                                                    -");
            Console.WriteLine("------------------------------------------------------");

        }
        public static void ShowResta(decimal ResultResta)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-                                                    -");
            Console.WriteLine("- Resultado suma:" + ResultResta);
            Console.WriteLine("-                                                    -");
            Console.WriteLine("------------------------------------------------------");

        }
        public static void ShowMulti(decimal ResultMulti)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-                                                    -");
            Console.WriteLine("- Resultado suma:" + ResultMulti);
            Console.WriteLine("-                                                    -");
            Console.WriteLine("------------------------------------------------------");

        }
        public static void ShowDiv(decimal ResultDiv)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-                                                    -");
            Console.WriteLine("- Resultado suma:" + ResultDiv);
            Console.WriteLine("-                                                    -");
            Console.WriteLine("------------------------------------------------------");

        }
    }
}
