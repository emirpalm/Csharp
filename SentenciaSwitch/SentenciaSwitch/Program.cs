using System;

namespace SentenciaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.Write("Teclea un número de dia");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1: { Console.WriteLine("hoy es lunes"); break; }
                case 2: { Console.WriteLine("hoy es martes"); break; }
                case 3: { Console.WriteLine("hoy es miercoles"); break; }
                case 4: { Console.WriteLine("hoy es jueves"); break; }
                case 5: { Console.WriteLine("hoy es viernes"); break; }
                case 6: { Console.WriteLine("hoy es sábado"); break; }
                case 7: { Console.WriteLine("hoy es domingo"); break; }
                default: { Console.WriteLine("no corresponde con un día de la semana"); break; }
                    }
            Console.ReadKey();
        }
    }
}
