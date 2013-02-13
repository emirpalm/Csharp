using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiAplicacion_12
{
    class Perro
    {
        private string nombre;
        private int edad;
        private string raza;
        public bool pedigree;

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
