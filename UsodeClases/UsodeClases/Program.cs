using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsodeClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Pasiva persona = new Pasiva();
            persona.edad = 10;
            persona.nom = "Emir";
            Console.WriteLine("Nombre "+persona.nom+"\nEdad "+ persona.edad);
            persona.imprimir();
            Console.ReadKey();
        }
    }
}
