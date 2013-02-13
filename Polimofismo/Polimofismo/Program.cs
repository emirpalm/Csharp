using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimofismo
{
    public class trabajador
    {
        public string nombre;
        public double sueldo;

        public virtual double impuesto()
        {
            return sueldo*.02;
        }
    }

    public class docente : trabajador
    {
        public override double impuesto()
        {
            
            return sueldo*.10;
        }
    }
    public class administrativo : trabajador
    {
        public override double impuesto()
        {
            return sueldo*.05;
        }
    }

    public class intendente : trabajador
    { 
     
    }

    class Program
    {
        static void Main(string[] args)
        {
            docente d = new docente();
            intendente i = new intendente();
            administrativo a = new administrativo();

            d.sueldo = 1000;
            i.sueldo = 1000;
            a.sueldo = 1000;

            Console.WriteLine("impuesto a Pagar");
            Console.WriteLine("docentes: "+d.impuesto());
            Console.WriteLine("intendente: " + i.impuesto());
            Console.WriteLine("administrativo: " + a.impuesto());
            Console.ReadKey();
        }
    }
}
