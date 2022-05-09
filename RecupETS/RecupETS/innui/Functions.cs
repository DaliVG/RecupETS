﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupETS
{
    class Functions
    {
        public static decimal AskNumbers()
        {
            decimal number = 0;
            bool valido = false;
            do
            {
                Console.WriteLine("Introduzca número: ");
                if (decimal.TryParse(Console.ReadLine(), out number))
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("El valor introducido no es un número.");
                    Console.ReadKey();
                }
            }
            while (!valido);

            return number;
        }

        public static void Adios()
        {
            Console.WriteLine("Pulse una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
