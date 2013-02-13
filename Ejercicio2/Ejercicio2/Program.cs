using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, res, op;
            Console.WriteLine("Teclee un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Teclee el segundo numero");
            b = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("1 Suma");
                Console.WriteLine("2 resta");
                Console.WriteLine("3 multiplicacion");
                Console.WriteLine("4 divicion");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: { res = a + b; Console.WriteLine("el resultado es: " + res); break; }
                    case 2: { res = a - b; Console.WriteLine("el resultado es: " + res); break; }
                    case 3: { res = a * b; Console.WriteLine("el resultado es: " + res); break; }
                    case 4: { res = a / b; Console.WriteLine("el resultado es: " + res); break; }
                    case 5: { break; }
                    default: { Console.WriteLine("opcion Incorrecta"); break; }
                }
         } while (op != 5);

            }
        }
    }

