using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=5, a=0, b=0, res=0;
            do
            {
                Console.WriteLine("teclea una opción");
                Console.WriteLine("1.- Suma");
                Console.WriteLine("2.- Resta");
                Console.WriteLine("3.- Multiplicación");
                Console.WriteLine("4.- División");
                Console.WriteLine("5.- Salir");
                op = int.Parse(Console.ReadLine());
                if (op < 5 && op >= 1)
                {
                    Console.WriteLine("teclea un número");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("teclea un número");
                    b = int.Parse(Console.ReadLine());
                }
                switch (op)
                {
                    case 1: { res = a + b; break; }
                    case 2: { res = a - b; break; }
                    case 3: { res = a * b; break; }
                    case 4: { res = a / b; break; }
                    case 5: { break; }
                    default: { Console.WriteLine("opciòn incorrecta"); break; }
                }
                if (op >= 1 && op < 5)
                {
                    Console.WriteLine("El resultado es: " + res);
                }
                Console.ReadKey();
            } while (op != 5);
        }
    }
}
