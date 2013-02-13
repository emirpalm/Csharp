using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiAplicacion_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro galgo;
            Perro pitbull;
            Perro sanbernardo;

            galgo = new Perro("Pepe", 4, "Galgo", true);
            pitbull = new Perro("Polo", 2, "Pitbull", false);
            sanbernardo = new Perro("Rocko", 2, "San Bernardo", true);
        }
    }
}
