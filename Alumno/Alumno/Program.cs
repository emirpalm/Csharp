using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alumno
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Alumno name = new Alumno();

            Console.Write("Ingresa la matricula: ");
            name.matricula = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el nombre: ");
            name.nombre = Console.ReadLine();
            Console.Write("Ingresa la edad: ");
            name.edad = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el semestre: ");
            name.semestre = int.Parse(Console.ReadLine());
            Console.Write("Ingresa la carrera: ");
            name.carrera = Console.ReadLine();
            

            do
            {
                Console.Clear(); op = 0;
                Console.WriteLine("Modifica los datos que que quieras con el siguiente menu");
                Console.WriteLine("1.- Promocion\n2.- Cambiar carrera\n3.- Cumpleaños\n4.- Cambiar Matricula\n5.- Imprimir\n6.- Salir");
                op = int.Parse(Console.ReadLine());
                

                switch(op)
                {
                    case 1: { Console.WriteLine("Ingresa la Promocion: "); name.promocion(); break; }
                    case 2: { Console.WriteLine("Ingresa la Carrera: "); name.cambiodecarrera(); break; }
                    case 3: { Console.WriteLine("Ingresa el Cumpleaños: "); name.cumpleanos(); break; }
                    case 4: { Console.WriteLine("Ingresa la Matricula: "); name.cambiomatricula();  break; }
                    case 5: Console.WriteLine("Matricula: " + name.matricula + "\nNombre: " + name.nombre + "\nEdad: " + name.edad + "\nSemestre: " + name.semestre + "\nCarrera: " + name.carrera + "\nPresione una tecla para Continuar");
                        Console.Write("© 2011. ITSPROGRESO. All Rights Reserved. ");
                        Console.ReadKey(); break;
                    case 6: { break; }
                    default: { Console.WriteLine("opcion Incorrecta"); break; }
                }
            } while (op != 6);

        }
    }
}
