using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadoracien
{
    class calc
    {
        private int a, b;
        public int Seta(int z)
        {
        return a = z;
        }

        public int Setb(int z)
        {
          return b = z;
        }

        public int suma()
        {
            
            return a+b;
        }

        public int resta()
        {
            
            return a-b;
        }

        public int mul()
        {
            
            return a*b;
        }
        public int div() 
        {
            return a / b;
        }
        

    }

    class Cientifica : calc {
        private double a, b;
        public void Setad(double z) {
            a = z;
        }

        public void Setbd(double z)
        {
            b = z;
        }

  public double Pot(){
    return Math.Pow(a,b);
    }
  public double R()
  {
      return Math.Pow(a, 1/b);
  }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cientifica p = new Cientifica(); //constructor
            
            int x, y, op; double xd, yd;

            do
            {
                Console.WriteLine("1.- Suma\n2.- resta\n3.- multiplicacion\n4.- divisicon\n5.- potencia\n6.- raiz\n7.- salir");
                op = int.Parse(Console.ReadLine());

                if(op != 5 && op != 6){
                
            Console.WriteLine("teclee el primer valor: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("teclee el segundo valor: ");
            y = int.Parse(Console.ReadLine());
            p.Seta(x); p.Setb(y);
                }else{

                 Console.WriteLine("teclee el primer valor: ");
            xd = double.Parse(Console.ReadLine());

            Console.WriteLine("teclee el segundo valor: ");
            yd = double.Parse(Console.ReadLine());
            p.Setad(xd); p.Setbd(yd);
                }
                switch (op)
                {
                    case 1: Console.WriteLine("La suma es: "+p.suma()); break;
                    case 2: Console.WriteLine("La resta es: " + p.resta()); break;
                    case 3: Console.WriteLine("La mult es: " + p.mul()); break;
                        case 4: Console.WriteLine("La Division es: " + p.div()); break;
                        case 5: Console.WriteLine("La Potencia es: " + p.Pot()); break;
                        case 6: Console.WriteLine("La raiz es: " + p.R()); break;
                    case 7: { break; }
                    default: { Console.WriteLine("opcion Incorrecta"); break; }
                }
            } while (op != 5);
            {
                Console.WriteLine(p.suma());
            }
            Console.ReadKey();
        }
    }
}
