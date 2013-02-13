using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiAplicacion_11
{
    class Perro
    {
        string nombre;
        int edad;
        string raza;
        bool pedigree;

        public Perro(string Nombre, int Edad, string Raza, bool Pedigree) // Constructor
        {
            nombre = Nombre;
            edad = Edad;
            raza = Raza;
            pedigree = Pedigree;

            if (pedigree == true)
            {
                Console.WriteLine("El nombre del perro es " + nombre + ", tiene la edad "
                + edad + ", la raza es " + raza + "y posee Pedigree");
            }
            else
            {
                Console.WriteLine("El nombre del perro es " + nombre + ", tiene la edad "
                + edad + ", la raza es " + raza + "y no posee Pedigree");
            }

        }

    }
}
