using System;

namespace SentenciaIf
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b = "paol";
            Console.Write("teclea la constraseña: ");
            a = Console.ReadLine();
            if (a == b)
            {
                Console.WriteLine("acceso autorizado");
            }
            else
            {
                Console.WriteLine("acceso denegado");
            }
            Console.ReadKey();
        }
    }
}
