using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encapsulado
{   
    //nueva clase
    class Punto
    {
        private int x, y;
        public Boolean setx(int z)
        {
            if (z >= 0 && z <= 1024)
            { x = z; return true; }
            else
                return false;
        }

        public Boolean sety(int z)
        {
            if (z >= 0 && z <= 768)
            { y = z; return true; }
            else
                return false;
        }

        public int getx()
        { 
            return x; 
        }

        public int gety()
        { 
            return y; 
        }

    }
    //termina mi clase punto
    class Program
    {
        static void Main(string[] args)
        {
            Punto p = new Punto(); //constructor
            int a, b;
            Console.WriteLine("teclee el valor horizontal: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("teclee el valor vertical: ");
            b = int.Parse(Console.ReadLine());
            if (p.setx(a) && p.sety(b))
            { Console.WriteLine("cambio realizado"); }
            else
                Console.WriteLine("configuracion inconrrecta");
            Console.WriteLine(p.getx() +","+ p.gety());
            Console.ReadKey();
        }
    }
}
