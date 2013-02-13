using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Software
{
    class alumno
    {
        public String nombre;
        public int matricula, i;
        public int cal, s;

        public virtual double Promedio() {
            return s / 5;
        }

       public virtual void MostrarDatos()
        {
            Console.Clear();
            Console.WriteLine("Nombre: " + nombre + "\nMatricula: " + matricula);
            Console.WriteLine("Su Calificacion final es: " + s);
            Console.WriteLine("Su Promedio es : " + Promedio());
            if (Promedio() < 6)
             Console.WriteLine("Esta Reprobado");
            else
                Console.WriteLine("Aprobo");

            Console.WriteLine("Presione una tecla para voler al menu...");
            Console.ReadKey();

        }
    }
    class primaria : alumno
    {
        public void SetC()
        {
            s = 0;
            for (i = 1; i < 6; i++)
            {
                Console.WriteLine("dame la " + i + " Calificacion");
                cal = int.Parse(Console.ReadLine());
                while (cal < 0 || cal > 10)
                {
                    Console.WriteLine("Calificacion invalida teclee una entre el rango de 5 y 10 sin decimales gracias");
                    cal = int.Parse(Console.ReadLine());
                    if (cal < 5)
                    {
                        cal = 5;
                    }
                }
                s += cal;
            }
        }
    }

    class prepa : alumno
    {
        double dcal, su;
        public void SetCal()
        {
            su = 0;
            for (i = 1; i < 5; i++)
            {
                Console.WriteLine("dame la " + i + " Calificacion");
                dcal = double.Parse(Console.ReadLine());
                while (dcal < 0 || dcal > 100)
                {
                Console.WriteLine("Calificacion invalida teclee una entre el rango de 0 y 100");
                dcal = double.Parse(Console.ReadLine());
                }
                su += dcal;
            }
        }

        public override double Promedio()
        {
            return su / 4;
        }     
        public override void MostrarDatos()
        {
            Console.Clear();
            Console.WriteLine("Nombre: " + nombre + "\nMatricula: " + matricula);
            Console.WriteLine("Su Calificacion final es: " + su);
            Console.WriteLine("Su Promedio es : " + Promedio());
            if (Promedio() < 70)
             Console.WriteLine("Esta Reprobado");
            else
                Console.WriteLine("Aprobo");

            Console.WriteLine("Presione una tecla para voler al menu...");
            Console.ReadKey();

    }
 }
    

    class Program
    {
        static void Main(string[] args)
        {
            int op;
            primaria chicos= new primaria();
            prepa grandes = new prepa();
            do
            {
                Console.Clear(); op = 0;
                Console.WriteLine("Menu");
                Console.WriteLine("1.- Primaria o Secundaria \n2.- Prepa o Universidad\n3.- Salir");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("Ingresa el nombre: ");
                        chicos.nombre = Console.ReadLine();
                        Console.Write("Ingresa la matricula: ");
                        chicos.matricula = int.Parse(Console.ReadLine());
                        chicos.SetC(); chicos.MostrarDatos();  break;

                    case 2: 
                        Console.Write("Ingresa el nombre: ");
                        grandes.nombre = Console.ReadLine();
                        Console.Write("Ingresa la matricula: ");
                        grandes.matricula = int.Parse(Console.ReadLine());
                        grandes.SetCal(); grandes.MostrarDatos();  break;                  
                    case 3: break; 
                    default: Console.WriteLine("opcion Incorrecta"); break;
                }
            }while (op != 3);
        }
   }
 }
